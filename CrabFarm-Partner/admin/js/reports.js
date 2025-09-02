$(function () {
    // Fetch data from backend API
    $.getJSON('/api/reports-data', function (data) {
      // Update summary cards
      $('#totalSubscribers').text(data.totalSubscribers);
      $('#activeSubscribers').text(data.activeSubscribers);
      $('#expiredSubscribers').text(data.expiredSubscribers);
  
      // Weekly Subscribers Chart
      new Chart($("#weeklySubscribersChart"), {
        type: 'line',
        data: {
          labels: data.weeklySubscribers.labels,
          datasets: [{
            label: 'New Subscribers',
            data: data.weeklySubscribers.data,
            borderWidth: 2,
            borderColor: '#004aad',
            fill: true,
            backgroundColor: 'rgba(0,74,173,0.1)'
          }]
        }
      });
  
      // Active vs Expired Pie Chart
      new Chart($("#activeExpiredChart"), {
        type: 'doughnut',
        data: {
          labels: ['Active', 'Expired'],
          datasets: [{
            data: [data.activeSubscribers, data.expiredSubscribers],
            backgroundColor: ['#28a745', '#dc3545']
          }]
        }
      });
    }).fail(function () {
      console.error("Failed to load reports data from /api/reports-data");
    });
  });
  