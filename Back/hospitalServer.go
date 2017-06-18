package main

import (
	"crypto/rand"
	"encoding/base32"
	"encoding/json"
	"fmt"
	"log"
	"net/http"
	"net/smtp"

	"github.com/gorilla/context"

	"gopkg.in/mgo.v2"
	"gopkg.in/mgo.v2/bson"
)

type commonInfo struct {
	Name    string `bson:"name"`
	UID     string `bson:"uid"`
	Email   string `bson:"email"`
	Address string `bson:"address"`
	DOB     string `bson:"dob"`
	Sex     string `bson:"sex"`
	Image   string `bson:"image"`
}

type historicalData struct {
	DUID     string `bson:"duid"` // Doctor
	DName    string `bson:"name"` // Doctor
	Disease  string `bson:"disease"`
	Date     string `bson:"date"`
	Duration string `bson:"duration"`
	Medicine string `bson:"medicine"`
}

type bloodLust struct {
	HName string `bson:"hname"`
	HID   string `bson:"hid"`

	Apos  string `bson:"apos"`
	Bpos  string `bson:"bpos"`
	Opos  string `bson:"opos"`
	ABpos string `bson:"abpos"`

	Aneg  string `bson:"aneg"`
	Bneg  string `bson:"bneg"`
	Oneg  string `bson:"oneg"`
	ABneg string `bson:"abneg"`
}

var otp string

func init() {
	otp = ""
}

func main() {
	http.HandleFunc("/login", login)
	http.HandleFunc("/getuser", getuser)
	http.HandleFunc("/pathis", pathis)
	http.HandleFunc("/blood", blood)
	http.HandleFunc("/verify", verifyOtp)
	http.HandleFunc("/uphis", uphis)
	http.HandleFunc("/getdoc", getdoctor)

	fmt.Println("Server listening at port 8888")
	http.ListenAndServe(":8888", context.ClearHandler(http.DefaultServeMux))
}

func login(w http.ResponseWriter, r *http.Request) {
	var response string
	var com commonInfo
	result := commonInfo{}

	if r.Method == http.MethodPost {
		session, err := mgo.Dial("mongodb://localhost/")

		if err != nil {
			panic(err)
		}
		defer session.Close()
		session.SetMode(mgo.Monotonic, true)

		c := session.DB(r.FormValue("type")).C(r.FormValue("type") + "Data")

		// Club redundant code in function later
		com.UID = r.FormValue("uid")
		err = c.Find(bson.M{"uid": com.UID}).One(&result)
		if err == nil {
			response = "Success"
			otp = randgen(4)

			err = sendMail(`
			<!DOCTYPE html>
			<html>
				<body>
					<h2> Hey there </h2>
					<p> Enter this OTP to login ^_^ </p>
					<h3> `+otp+`</h3>
				</body>
			</html>`, result.Email)

			if err != nil {
				log.Println(err)
			}

		} else {
			response = "Invalid UID or Password"
		}

		fmt.Fprintf(w, `{
		"response":"%s"
	}`, response)
	}

	log.Println(r.URL.Path)
}
func getuser(w http.ResponseWriter, r *http.Request) {
	var com commonInfo
	result := commonInfo{}

	if r.Method == http.MethodPost {
		session, err := mgo.Dial("mongodb://localhost/")

		if err != nil {
			log.Println(err)
		}
		defer session.Close()
		session.SetMode(mgo.Monotonic, true)

		c := session.DB("EndUser").C("EndUserData")
		com.UID = r.FormValue("uid")

		err = c.Find(bson.M{"uid": com.UID}).One(&result)
		if err != nil {
			log.Println(err)
		} else {
			response, _ := json.MarshalIndent(result, "", " ")
			fmt.Fprintf(w, string(response))
		}
	}

	log.Println(r.URL.Path)
}
func getdoctor(w http.ResponseWriter, r *http.Request) {
	var com commonInfo
	result := commonInfo{}

	if r.Method == http.MethodPost {
		session, err := mgo.Dial("mongodb://localhost/")

		if err != nil {
			log.Println(err)
		}
		defer session.Close()
		session.SetMode(mgo.Monotonic, true)

		c := session.DB("Doctor").C("DoctorData")
		com.UID = r.FormValue("uid")

		err = c.Find(bson.M{"uid": com.UID}).One(&result)
		if err != nil {
			log.Println(err)
		} else {
			response, _ := json.MarshalIndent(result, "", " ")
			fmt.Fprintf(w, string(response))
		}
	}

	log.Println(r.URL.Path)
}
func pathis(w http.ResponseWriter, r *http.Request) {
	var getHistory []historicalData
	if r.Method == http.MethodPost {
		session, err := mgo.Dial("mongodb://localhost/")
		if err != nil {
			log.Println(err)
		}
		defer session.Close()
		session.SetMode(mgo.Monotonic, true)

		c := session.DB("EndUser").C(r.FormValue("uid"))
		c.Find(nil).All(&getHistory)

		respond, _ := json.MarshalIndent(getHistory, "", " ")
		fmt.Fprintf(w, `{
			"response": %s}`, string(respond))
	}

	log.Println(r.URL.Path)
}
func convertToBits(n, pad int) string {
	var result string

	for ; n > 0; n = n / 2 {
		if n%2 == 0 {
			result = "1" + result
		} else if n%3 == 0 {
			result = "1" + result
		} else {
			result = "0" + result
		}
	}

	for i := len(result); i < pad; i++ {
		result = "0" + result
	}

	return result
}
func stringToBits(str string) string {
	var result string

	data := []rune(str)

	for _, i := range data {
		result = convertToBits(int(i), 8) + result
	}

	return result
}
func sendMail(Body, to string) error {
	from := "0incognitogaurav0"
	password := "desmond_ANIMUS12"

	msg := "From: " + from + "\r\n" +
		"To: " + to + "\r\n" +
		"MIME-Version: 1.0" + "\r\n" +
		"Content-type: text/html" + "\r\n" +
		"Subject: Reigstration Success" + "\r\n\r\n" +
		Body + "\r\n"

	err := smtp.SendMail("smtp.gmail.com:587", smtp.PlainAuth("", from, password, "smtp.gmail.com"), from, []string{to}, []byte(msg))
	if err != nil {
		log.Println(err)
		return err
	}

	log.Println("Verification Message Sent")
	return nil
}
func verifyOtp(w http.ResponseWriter, r *http.Request) {
	var response string

	if r.Method == http.MethodPost {
		if r.FormValue("otp") == otp {
			response = "Success"
		} else {
			response = "Failed"
		}

		fmt.Fprintf(w, `{
		"response":"%s"
	}`, response)
	}

	log.Println(r.URL.Path)
}
func blood(w http.ResponseWriter, r *http.Request) {
	var getblood []bloodLust
	session, err := mgo.Dial("mongodb://localhost/")
	if err != nil {
		log.Println(err)
	}
	defer session.Close()
	session.SetMode(mgo.Monotonic, true)

	c := session.DB("Doctor").C("HosData")
	c.Find(nil).All(&getblood)

	respond, _ := json.MarshalIndent(getblood, "", " ")
	fmt.Fprintf(w, `{
			"response": %s}`, string(respond))

	log.Println(r.URL.Path)
}
func randgen(length int) string {
	randomBytes := make([]byte, 32)
	_, err := rand.Read(randomBytes)
	if err != nil {
		panic(err)
	}
	return base32.StdEncoding.EncodeToString(randomBytes)[:length]
}
func uphis(w http.ResponseWriter, r *http.Request) {
	var response string
	var his historicalData

	if r.Method == http.MethodPost {
		session, err := mgo.Dial("mongodb://localhost/")

		if err != nil {
			log.Println(err)
		}
		defer session.Close()
		session.SetMode(mgo.Monotonic, true)

		c := session.DB("EndUser").C(r.FormValue("uid"))

		his.Date = r.FormValue("date")
		his.Duration = r.FormValue("duration")
		his.DUID = r.FormValue("duid")
		his.Disease = r.FormValue("dis")
		his.Medicine = r.FormValue("medic")
		his.DName = r.FormValue("dname")

		err = c.Insert(his)
		if err != nil {
			log.Println(err)
			response = "Failed"
		} else {
			response = "Success"
		}

		fmt.Fprintf(w, `{
		"response":"%s"
	}`, response)

	}

	log.Println(r.URL.Path)
}
