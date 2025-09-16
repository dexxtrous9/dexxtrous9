$(document).ready(function () {
    $("#btnCheck").click(function () {
      $("#demoResult").text("Tank checked: All systems normal.").removeClass().addClass("text-success");
    });
  
    $("#btnFeed").click(function () {
      $("#demoResult").text("Feeding started: Crabs are being fed automatically.").removeClass().addClass("text-info");
    });
  
    $("#btnAlert").click(function () {
      $("#demoResult").text("No alerts at this time.").removeClass().addClass("text-warning");
    });
  });
  