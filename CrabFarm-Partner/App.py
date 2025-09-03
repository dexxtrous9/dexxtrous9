from flask import Flask, render_template

app = Flask(__name__)

@app.route("/")
def home():
    return render_template("web/index.html", content="Your Partner", css_file="css/web/index.css")

@app.route("/about")
def about():
    return render_template("web/about.html", content="About", css_file="css/web/about.css")

@app.route("/contact")
def contact():
    return render_template("web/contact.html", content="Contact", css_file="css/web/contact.css")

@app.route("/demo")
def demo():
    return render_template("web/about.html", content="Demo")

@app.route("/auth/login")
def login():
    return render_template("auth/login.html", content="Login", css_file="css/auth/login.css")

@app.route("/auth/signup")
def signup():
    return render_template("auth/signup.html", content="Sign-Up", css_file="css/auth/signup.css")


if __name__ == "__main__":
    app.run(debug=True)