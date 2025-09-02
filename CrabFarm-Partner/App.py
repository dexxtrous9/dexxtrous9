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


if __name__ == "__main__":
    app.run(debug=True)