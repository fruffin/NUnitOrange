namespace NUnitOrange
{
    internal class Markup
    {
        public static string Base
        {
            get
            {
                return @"<!DOCTYPE html>
<html xmlns='http://www.w3.org/1999/xhtml' xml:lang='en'> 
<!--
	NUnit Orange Library v1.0 | http://relevantcodes.com/nunit-orange-nunit-html-report-generator/ | https://github.com/relevantcodes/
--> 
	<head>
		<title>NUnit Orange</title>
		<link href='http://fonts.googleapis.com/css?family=Open+Sans:300,400,600,700' rel='stylesheet' type='text/css' />
		<link href='http://maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css' rel='stylesheet' />
		<style type='text/css'>
			html {
				overflow-y: scroll;}
			* {
			    -webkit-box-sizing: border-box;
				    -moz-box-sizing: border-box;
					    box-sizing: border-box;
			}
			*:before, *:after {
				box-sizing: border-box;
			}
			*:before, *:after {
				box-sizing: border-box;
			}
			body {
				color: #222;
				font-family: Lato, 'Open Sans', Calibri;
				font-size: 13px;
			}
			pre {
				background: none repeat scroll 0 0 #f5f6f8;
				color: #222;
				padding: 5px 10px;
				text-transform: none !important;
				white-space: pre-wrap;
			}
			#container {
			
			}
			#header {
				background: #eee;
				margin: 20px auto 0;
				width: 1025px;
			}
			#title {
				padding: 10px 15px;
			}
			#content {
				width: 1025px;
				margin: 0 auto 100px;
			}
			#header-summary {
				font-size: 14px;
				font-weight: 300;
				line-height: 25px;
				width: 80%;
			}
			#test-filters {
				font-weight: 300;
				margin-bottom: 20px;
			}
			#summary-container {
				border: 1px solid #d3d8db;
                border-radius: 4px;
				height: auto;
				margin: 30px auto 50px;
				padding: 5px 0;
				width: 1025px;
			}
			#tabs ul {
				list-style: none;
				margin: 20px 0 20px 20px;
				padding: 0;
			}
			#tabs ul li {
				border: 1px solid #e0e0e0;
				display: inline;
				margin-bottom: 5px;
				padding: 10px 15px;
				white-space: nowrap;
			}
			#tabs li a {
				color: #444;
                font-weight: 400;
				text-decoration: none;
			}
			#tabs li a:hover {
				color: #999;
			}
			.graphs {
				margin-left: 50px
			}
			#summary {
				float: left;
				margin-top: 15px;
			}
			.summary-items {
				padding: 10px 0 40px;
			}
			.summary-item {
				background-color: #fafbfc;
				border: 1px solid #e5e5e5;
				display: inline-block;
				margin: 12px 5px 0;
				padding: 25px 0;
				text-align: center;
				width: 200px;
			}
			.summary-item span {
				color: #777;
				display: block;
			}
			.summary-value {
				font-size: 18px;
				font-weight: 600;
			}
			.summary-param {
				color: #222 !important;
				font-size: 12px;
				font-weight: 300;
				text-transform: uppercase;
			}
			.fixture-collection {
				max-width: 1025px;
			}
			.fixture-container {
				border: 1px solid #d3d8db;
				border-radius: 3px;
				float: left;
				margin-bottom: 5px;
				height: 82px;
				width: 337px;
			}
			.fixture-head {
				color: #000;
				cursor: pointer;
				font-size: 16px;
				font-weight: 300;
                height: 60px;
				padding: 15px;
				transition: all 0.2s ease-in-out 0s;
			}
			.fixture-name {
				max-width: 260px;
			}
			.fixture-result {
				float: right;
				font-size: 13px;
				right: 25px;
			}
			.fixture-head span {
				bottom: 20px;
				position: absolute;
				width: 0;
			}
			.is-expanded {
				height: auto;
			}
			.is-expanded .fixture-head {
				background-color: #555;
				color: #fff;
			}
			.is-failed {
				height: auto;
				width: 677px;
			}
			.head-height {
				height: auto;
				padding-bottom: 30px;
			}
			.fixture-expanded {
				top: 12px;
			}
			.fixture-content {
				padding: 25px 0 30px;
			}
			.simple-grey {
				border-collapse: collapse;
				color: #444;
				margin: 0 auto;
				text-align: left;
				width: 95%;
			}
			#tabs-2 .simple-grey {
				border-collapse: collapse;
				color: #444444;
				margin: 40px 0 20px 40px;
				width: 95%;
			}
			.simple-grey tr {
				border-bottom: 1px solid #e5e5e5;
			}
			.simple-grey tr:last-child {
				border-bottom: none;
			}
			.simple-grey th, .simple-grey td {
				padding: 6px 8px;
				text-align: left;
			}
			.simple-grey td {
                font-size: 14px;
				font-weight: 300;
				word-break: break-all;
			}
			.simple-grey td:first-child {
				min-width: 150px;
				padding-right: 25px;
			}
			.simple-grey td:nth-child(2) {
				min-width: 60px;
				padding-right: 25px;
			}
			#tabs .simple-grey { 
				border: 1px solid #e7e7e7;
			}
			#tabs .simple-grey th { 
				background-color: #444;
				color: #fff;
			}
			#tabs .simple-grey td:first-child {
				width: 250px;
			}
			.report-img {
				border: 4px solid #eee;
				display: block;
				height: auto;
				margin-top: 15px;
				text-align: center;
				width: 95%;
			}
			.cs-btn {				
				border: 1px solid;
				border-radius: 0.2em;
				cursor: pointer;
				display: inline;
				font-size: 11px;
				font-weight: 600;
				line-height: 13.4667px;
				padding: 6px 15px;
				text-decoration: none;
				text-transform: uppercase;
				transition: all 0.2s ease-in-out 0s;
			}
			.cs-btn i {
				padding-right: 5px;
			}
			.cs-btn-green {
				border-color: #5cb85c;
				color: #5cb85c;
			}
			.cs-btn-green:hover {
				background-color: #5cb85c;
				color: white;
			}
			.cs-btn-red {
				border-color: #d9534f;
				color: #d9534f;
			}
			.cs-btn-red:hover {
				background-color: #d9534f;
				color: white;
			}
			.cs-btn-orange {
				border-color: #f0ad4e;
				color: #f0ad4e;
			}
			.cs-btn-orange:hover {
				background-color: #f0ad4e;
				color: white;
			}
			.cs-btn-grey {
				border-color: #888;
				color: #888;
			}
			.cs-btn-grey:hover {
				background-color: #888;
				color: white;
			}
			.failed, .passed, .warning, .bad, .inconclusive, .skipped {
				text-transform: uppercase;
				font-size: 13px;
			}
			.failed {
				color: #e67672;
			}
			.passed {
				color: #5cb85c;
			}
			.warning, .bad, .inconclusive {
				color: #f0ad4e;
			}
			.skipped {
				color: #999;
			}
		</style>
	</head>
	<body>
		<div id='container'>
			<div id='header'>
				<div id='title'>
					<i class='fa fa-desktop' style='margin-right:10px;'></i><span>NUnit <span style='color:#ef5f3c;'>Orange</span></span>
				</div>
			</div>
			
			<div id='summary-container'>
				<div id='tabs'>
					<ul>
						<li><a href='#tabs-1' class='tabs-1 name'><i class='fa fa-pie-chart'></i> &nbsp;&nbsp;Quick Summary</a></li>
						<li><a href='#tabs-2' class='tabs-2 name'><i class='fa fa-archive'></i> &nbsp;&nbsp;Detailed Info</a></li>
					</ul>
					<div id='tabs-1'>
						<div class='graphs'>
							<div id='summary'></div>
							<div class='summary-items'>
					            <div class='summary-item'>
						            <span class='summary-value'>32</span>
						            <span class='summary-param'>Total Tests</span>
					            </div>
					            <div class='summary-item'>
						            <span class='summary-value'>20</span>
						            <span class='summary-param'>Passed</span>
					            </div>
					            <div class='summary-item'>
						            <span class='summary-value'>7</span>
						            <span class='summary-param'>Failed</span>
					            </div>
					            <div class='summary-item'>
						            <span class='summary-value'>1</span>
						            <span class='summary-param'>Inconclusive</span>
					            </div>
					            <div class='summary-item'>
						            <span class='summary-value'>4</span>
						            <span class='summary-param'>Skipped</span>
					            </div>
					            <div class='summary-item'>
						            <span class='summary-value'>0.066000</span>
						            <span class='summary-param'>Duration</span>
					            </div>
				            </div>
						</div>
					</div>
					<div id='tabs-2'>
						<table class='simple-grey'>
							<thead>
								<tr><th>Param</th><th>Value</th></tr>
								<tr><td>Random Seed</td><td><!--%RANDOMSEED%--></td></tr>
								<tr><td>Duration</td><td><!--%DURATION%--></td></tr>
								<tr><td>Start Time</td><td><!--%STARTTIME%--></td></tr>
								<tr><td>End Time</td><td><!--%ENDTIME%--></td></tr>
								<tr><td>Result</td><td><!--%RESULT%--></td></tr>
								<tr><td>Full Name</td><td><!--%FULLNAME%--></td></tr>
								<tr><td>Name</td><td><!--%NAME%--></td></tr>
								<tr><td>ID</td><td><!--%ID%--></td></tr>
								<tr><td>Culture</td><td><!--%CULTURE%--></td></tr>	
								<tr><td>User Domtain</td><td><!--%USERDOMAIN%--></td></tr>
								<tr><td>User</td><td><!--%USER%--></td></tr>
								<tr><td>Machine Name</td><td><!--%MACHINENAME%--></td></tr>
								<tr><td>Platform</td><td><!--%PLATFORM%--></td></tr>
								<tr><td>Os Version</td><td><!--%OSVERSION%--></td></tr>
								<tr><td>CLR Version</td><td><!--%CLRVERSION%--></td></tr>
								<tr><td>NUnit Version</td><td><!--%NUNITVERSION%--></td></tr>
							</thead>
						</table>
					</div>
				</div>
			</div>
			<div id='content'>
				<div id='test-filters'>Filter fixture by status:&nbsp;&nbsp;
					<div id='filter-passed' class='cs-btn cs-btn-green btn-toggle'><i class='fa fa-check'></i>PASSED</div>
					<div id='filter-failed' class='cs-btn cs-btn-red btn-toggle'><i class='fa fa-times'></i>FAILED</div>
					<div id='filter-inconclusive' class='cs-btn cs-btn-orange btn-toggle'><i class='fa fa-question'></i>INCONCLUSIVE</div>
					<div id='filter-skipped' class='cs-btn cs-btn-grey btn-toggle'><i class='fa fa-angle-double-right'></i>SKIPPED</div>
				</div>
				<div id='content-fixture'>
					<div id='fixture-collection'>
				        <!--%INSERTFIXTURE%-->
			        </div>
                </div>
            </div>
		</div>	
	</body>
	<script type='text/javascript' src='http://code.jquery.com/jquery-1.10.1.min.js'></script>
	<script type='text/javascript' src='https://www.google.com/jsapi'></script>
	<script src='http://cdnjs.cloudflare.com/ajax/libs/masonry/3.2.2/masonry.pkgd.min.js' type='text/javascript' charset='utf-8'></script>
	<script type='text/javascript'>
		$(document).ready(function() {
			var $container = $('#fixture-collection').masonry({
				columnWidth: 340,
				gutter: 2
			});
			$container.on( 'click', '.fixture-head', function() {
				var elm = $(this);
				if (elm.parent('.fixture-container').find('.fixture-content').is(':visible'))
					elm.children('span').toggleClass('fixture-expanded').parent().toggleClass('head-height').parent('.fixture-container').toggleClass('is-expanded').removeClass('is-failed').find('.fixture-content').fadeOut(0);
				else {
					if (elm.next().find('td.failed').length == 0 && elm.next().find('td.skipped').length == 0)
						elm.children('span').toggleClass('fixture-expanded').parent().toggleClass('head-height').parent('.fixture-container').toggleClass('is-expanded').find('.fixture-content').fadeIn();
					else
						elm.children('span').toggleClass('fixture-expanded').parent().toggleClass('head-height').parent('.fixture-container').toggleClass('is-expanded is-failed').find('.fixture-content').fadeIn();
				}
				$container.masonry();
			});
			$('#tabs').click(function(evt) {
				if (evt.target.className.match( /(fa|tabs)/ )) {
					var id = '#' + $(evt.target).attr('class').split(' ')[0];
					if (evt.target.className.indexOf('fa') == 0)
						id = '#' + $(evt.target).parent().attr('class').split(' ')[0];
					var tabs = $(this);var tab = tabs.find(id);var isVis = tab.is(':visible');evt.preventDefault();
					if (id == '#tabs-1' && isVis) { return; } 
					if (id == '#tabs-2' && isVis) { return; } 
					$('#tabs-1, #tabs-2').slideUp();tab.slideDown(); 
				}
			});
			$('.btn-toggle').click(function() {
				var btn = $(this); btn.toggleClass('selected');
				if ($(this).hasClass('selected'))
					btn.css('background-color', btn.css('border-left-color')).css('color', '#fff');
				else
					btn.css('background-color', '#fff').css('color', btn.css('border-left-color'));
				if (!$('.btn-toggle').hasClass('selected')) {
					$('.fixture-container').show();
					$('#fixture-collection').masonry();
					return;
				}
				$('.btn-toggle').each(function() {
					if ($(this).hasClass('selected'))
						$('.fixture-result.' + $(this).text().toLowerCase()).closest('.fixture-container').show();
					else {
						$('.fixture-result.' + $(this).text().toLowerCase()).closest('.fixture-container').hide();
					}
				});
				$('#fixture-collection').masonry();
			});
			$('.fixture-content').hide();
			$('#tabs-2').hide();
			//$('#tabs li:first-child').css('border', '1px solid #444');
		});
		google.load('visualization', '1', {packages:['corechart']});
		google.setOnLoadCallback(summary);
		function summary() {
			var data = google.visualization.arrayToDataTable([ ['Fixture Status', 'Count'], ['Pass', $('td.passed').length], ['Fail', $('td.failed').length], ['Inconclusive', $('td.inconclusive').length], ['Skipped', $('td.skipped').length] ]);
			var chart = new google.visualization.PieChart(document.getElementById('summary'));
			chart.draw(data, { chartArea: {left:0, 'width': '80%', 'height': '80%'}, backgroundColor: { fill:'transparent' }, colors: ['green', 'red', 'orange', '#777'], pieHole: 0.4, pieSliceText: 'value', height: 210, width: 300 });
		}
	</script>
</html>";
            }
        }

        public static string Fixture
        {
            get
            {
                return @"<div class='fixture-container'>
					<div class='fixture-head'>
						<span class='fixture-name'><!--%FIXTURENAME%--></span>
						<span class='fixture-result <!--%FIXTURERESULT%-->'><i class='fa <!--%FIXTURERESULTICO%-->'></i></span>
					</div>
					<div class='fixture-content'>
						<table class='simple-grey'>
							<tr>
								<th>TestName</th>
								<th>Status</th>
							</tr>
							<!--%INSERTTEST%-->
						</table>
					</div>
				</div>
                <!--%INSERTFIXTURE%-->";
            }
        }

        public static string Test
        {
            get
            {
                return @"<tr>
								<td><!--%TESTNAME%--></td>
								<td class='<!--%TESTSTATUS%-->'><!--%TESTSTATUS%--><!--%TESTSTATUSMSG%--></td>
							</tr>
                            <!--%INSERTTEST%-->";
            }
        }
    }
}
