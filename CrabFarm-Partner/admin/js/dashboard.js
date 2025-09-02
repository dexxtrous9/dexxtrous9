$(function () {
    // Fetch dashboard data
    $.ajax({
      url: "/database/dashboard.py", // replace with your backend endpoint
      method: "GET",
      dataType: "json",
      success: function (res) {
        // Update stats
        $(".card:contains('Total Subscribers') h2").text(res.stats.totalSubscribers);
        $(".card:contains('Active Subscriptions') h2").text(res.stats.activeSubscriptions);
        $(".card:contains('Subscribers Today') h2").text(res.stats.todaySubscribers);
        $(".card:contains('Expired') h2").text(res.stats.expired);
  
        // Update table
        let tbody = $("table tbody");
        tbody.empty();
        $.each(res.subscribers, function (i, sub) {
          let badgeClass = sub.status === "Active" ? "bg-success" : "bg-danger";
          tbody.append(`
            <tr>
              <td>${sub.name}</td>
              <td>${sub.email}</td>
              <td>${sub.start}</td>
              <td>${sub.daysLeft}</td>
              <td><span class="badge ${badgeClass}">${sub.status}</span></td>
            </tr>
          `);
        });
  
        // Render chart
        new Chart($("#subscribersChart"), {
          type: 'line',
          data: {
            labels: res.chart.labels,
            datasets: [{
              label: 'Subscribers',
              data: res.chart.data,
              borderWidth: 2,
              borderColor: '#004aad',
              fill: true,
              backgroundColor: 'rgba(0,74,173,0.1)'
            }]
          }
        });
      },
      error: function () {
        alert("Failed to load dashboard data.");
      }
    });
  });