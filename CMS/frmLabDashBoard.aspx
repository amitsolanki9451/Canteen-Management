<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmLabDashBoard.aspx.cs" Inherits="CMS.frmLabDashBoard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta name="description" content="" />
    <meta name="author" content="" />
    <title>CMS - Admin Control Panel</title>
    <%-- <meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />--%>
    <%--  <link rel="shortcut icon" href="favicon.ico" />--%>
    <!-- Bootstrap Core CSS -->
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <!-- Custom CSS -->
    <link href="css/modern-business.css" rel="stylesheet" />
    <!-- Custom Fonts -->
    <link href="css/font-awesome.min.css" rel="stylesheet" type="text/css" />
    <link href="css/animate.min.css" rel="stylesheet" type="text/css" />
    <link href="css/Site.css" rel="stylesheet" type="text/css" />
    <link href="http://fonts.googleapis.com/css?family=Open+Sans:300,400italic,700italic,400,700"
        rel="stylesheet" type="text/css" />
    <link href="css/main.css" rel="stylesheet" />
    <link href="css/util.css" rel="stylesheet" />

    <style type="text/css">
        .auto-style33 {
            color: #0066CC;
            font-size: 14px;
        }

        .auto-style34 {
            font-size: 16px;
        }

        .blink_text {
            -webkit-animation-name: blinker;
            -webkit-animation-duration: 1s;
            -webkit-animation-timing-function: linear;
            -webkit-animation-iteration-count: infinite;
            -moz-animation-name: blinker;
            -moz-animation-duration: 1s;
            -moz-animation-timing-function: linear;
            -moz-animation-iteration-count: infinite;
            animation-name: blinker;
            animation-duration: 1s;
            animation-timing-function: linear;
            animation-iteration-count: infinite;
            color: red;
        }

        .auto-style35 {
            font-size: medium;
        }

        .Addcss {
            margin-LEFT: 10px;
            text-align: left;
            color: #C01C25;
            font-size: 14px;
        }

        .Viewcss {
            text-align: right;
            color: #C01C25;
            font-size: 14px;
        }
        /* -----SVG Icons - svgicons.sparkk.fr----- */

        .svg-icon {
            width: 1em;
            height: 1em;
        }

            .svg-icon path,
            .svg-icon polygon,
            .svg-icon rect {
                fill: #4691f6;
            }

            .svg-icon circle {
                stroke: #4691f6;
                stroke-width: 1;
            }
    </style>
    <script type="text/javascript">
        var MyWindow;

        function OpenPopup() {
            MyWindow = window.open("Feedback.aspx", "_blank", "toolbar=yes, scrollbars=no, resizable=yes, top=80, left=500, width=480, height=530");
        }
        function OpenPopup1() {
            MyWindow = window.open("#", "_blank", "toolbar=yes, scrollbars=no, resizable=yes, top=80, left=500, width=480, height=530");
        }
        function PopupDFFS() {
            MyWindow = window.open("#", "_blank", "toolbar=yes, scrollbars=no, resizable=yes");
        }


        function ClosePopup() {
            MyWindow = window.close();
        }

        function showRockModal() {
            $('#RockModal').modal({
                keyboard: false,
                backdrop: 'static',
                show: true
            })
        }
        function hideRockModal() {
            $('#RockModal').modal({
                show: false
            })
        }
        //window.onload(function () {
        //    var open = $('#RockModal').hasClass('in');
        //    if (open == true) {
        //        showModal();
        //    }
        //});
        function showConnectModal() {
            $('#ConnectModal').modal({
                keyboard: false,
                backdrop: 'static',
                show: true
            })
        }
        function hideConnectModal() {
            $('#ConnectModal').modal({
                show: false
            })
        }
        //window.onload(function () {
        //    var open = $('#ConnectModal').hasClass('in');
        //    if (open == true) {
        //        showModal();
        //    }
        //});
    </script>
</head>

<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div>
            <!-- HEADER -->
            <table style="width: 100%; padding: 1px; border-bottom: thick double #32a1ce;" class="menubar">
                <tr>
                    <td style="height: auto">
                        <table style="width: 100%; padding: 1px; border: none">
                            <%-- <tr>
                                <td class="normalbrown" style="text-align: right">
                                    <span>
                                        <img src="Images/logo.png" style="width: 100px; height: 60px" />&nbsp;&nbsp;&nbsp;</span>
                                </td>
                            </tr>--%>
                            <tr>
                                <td style="background-color: #525252; color: white; height: 25px; text-align: right">
                                    <div class="pathway">
                                        <strong>Welcome ! [</strong>
                                        <asp:Literal runat="server" ID="litAdminName"></asp:Literal>
                                        ]
                                    </div>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td class="menudottedline" style="text-align: right;">
                        <strong>
                            <asp:LinkButton ID="lnkbtnHome" runat="server" OnClick="lnkbtnHome_Click" CausesValidation="False">Home</asp:LinkButton></strong>
                        |
                <strong>
                    <asp:LinkButton ID="lnkbtnLogout" runat="server" OnClick="lnkbtnLogout_Click" CausesValidation="False">Logout</asp:LinkButton></strong>&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
                </tr>
            </table>
            <br />


        </div>

        <%--Content --%>
        <%--  <div class="container-fluid">--%>

        <!-- Page Content -->
        <div class="container">

            <!-- Marketing Icons Section -->
            <div class="row">
                <div class="col-lg-12">
                    <h1 class="page-header wow fadeInLeft">
                        <img src="Styles/Login/images/HILLogo.jpg" alt="IMG">
                        <span style="color: #0051BA">Welcome to <strong>Carbon Lab Dashboard</strong></span>


                    </h1>


                </div>
            </div>
            <div class="row">


                <div class="col-md-4">
                    <div class="panel panel-info wow fadeInDown" data-wow-duration="1000ms" data-wow-delay="600ms">
                        <div class="panel-heading">
                            <h4>
                                <i class="fa fa-fw fa-check"></i>Lab RAW Material Entry Block </h4>
                        </div>
                        <div class="panel-body">
                            <%--&#9998; for report--%>
                            <p>

                                <a __designer:mapid="e" class="auto-style33"><span class="auto-style34">Coke Analysis</span></a>
                                <a __designer:mapid="e" class="Addcss" href="~/LabOnly/frmCokeAnalysis.aspx" runat="server">
                                    <span class="auto-style34" style="margin-left: 66px;">&#43; Add </span></a>

                                <%-- 
                                     <a __designer:mapid="e" class="Viewcss" href="TechTeam/frmButtWeightmentReport.aspx"><span class="auto-style34" style="margin-left: 20px;">&#20870; Report </span></a>--%>
                            </p>
                            &nbsp;
                                <p>

                                    <a __designer:mapid="e" class="auto-style33"><span class="auto-style34">Coke Join Sampling </span></a>
                                    <a __designer:mapid="e" class="Viewcss" href="~/LabOnly/frmCokeJoinSamplingEdit.aspx" runat="server">
                                        <span class="auto-style34" style="margin-left: 85px;">&#10070; View </span></a>
                                </p>
                            &nbsp;
                                <p>
                                    <a __designer:mapid="e" class="auto-style33"><span class="auto-style34">Pitch Analysis </span></a>
                                    <a __designer:mapid="e" class="Addcss" href="~/LabOnly/frmPitchAnalysis.aspx" runat="server">
                                        <span class="auto-style34" style="margin-left: 66px;">&#43; Add </span></a>
                                </p>
                            &nbsp;
                                <p>
                                    <a __designer:mapid="e" class="auto-style33"><span class="auto-style34">Pitch Join Sampling </span></a>
                                    <a __designer:mapid="e" class="Viewcss" href="~/LabOnly/frmPitchJoinSamplingEdit.aspx" runat="server">
                                        <span class="auto-style34" style="margin-left: 87px;">&#10070; View </span></a>

                                </p>
                             &nbsp;
                                <p>
                                    <a __designer:mapid="e" class="auto-style33"><span class="auto-style34">HFO Composite </span></a>
                                    <a __designer:mapid="e" class="Addcss" href="~/LabOnly/frmHFOComposite.aspx" runat="server">
                                        <span class="auto-style34" style="margin-left: 66px;">&#43; Add </span></a>
                                </p>

                            &nbsp;
                                <p>
                                    <a __designer:mapid="e" class="auto-style33"><span class="auto-style34">HFO Analysis </span></a>
                                    <a __designer:mapid="e" class="Addcss" href="~/LabOnly/frmHFOAnalysis.aspx" runat="server">
                                        <span class="auto-style34" style="margin-left: 66px;">&#43; Add </span></a>
                                </p>
                              
                        </div>
                    </div>
                </div>

                         <div class="col-md-6">
                        <div class="panel panel-warning wow fadeInDown" data-wow-duration="1000ms" data-wow-delay="600ms">
                            <div class="panel-heading">
                                <h4>User  Block</h4>
                            </div>
                            <div class="panel-body">
                                <p>
                                
                                <p>
                                  
                                    <a __designer:mapid="30" class="auto-style33"><span class="auto-style34">Change Password</span></a>
                                    <a __designer:mapid="e" class="Addcss" href="~/LabOnly/frmChangePassword.aspx" runat="server">
                                        <span class="auto-style34" style="margin-left: 18px;">&#9997; Change </span></a>

                                </p>


                            </div>
                        </div>
                    </div>

                <div class="col-md-6">
                    <div class="panel panel-info wow fadeInDown" data-wow-duration="1000ms" data-wow-delay="600ms">
                        <div class="panel-heading">
                            <h4>
                                <i class="fa fa-fw fa-check"></i>Process Sample  Entry Block </h4>
                        </div>
                        <div class="panel-body">
                            <%--&#9998; for report--%>
                            <p>
                                <a __designer:mapid="e" class="auto-style33"><span class="auto-style34">Process Sample</span></a>
                                <a __designer:mapid="e" class="Addcss" href="~/LabOnly/frmProcessSamples.aspx" runat="server">
                                    <span class="auto-style34" style="margin-left: 110px;">&#43; Add </span></a>
                                <a __designer:mapid="e" class="Viewcss" href="~/LabOnly/frmProcessSamplesEdit.aspx" runat="server">
                                    <span class="auto-style34" style="margin-left: 25px;">&#10070; View </span></a>
                                <a __designer:mapid="e" class="Viewcss" href="~/LabOnly/frmProcessSamplesSummaryReport.aspx" runat="server">
                                    <span class="auto-style34" style="margin-left: 35px;">&#20870; Report </span></a>


                            </p>
                            &nbsp;
                                <p>

                                    <a __designer:mapid="e" class="auto-style33"><span class="auto-style34">GAPFines J050</span></a>
                                    <a __designer:mapid="e" class="Addcss" href="~/LabOnly/frmGapFinesJ050.aspx" runat="server">
                                        <span class="auto-style34" style="margin-left: 115px;">&#43; Add </span></a>
                                    <a __designer:mapid="e" class="Viewcss" href="~/LabOnly/frmGapFinesEdit.aspx" runat="server">
                                        <span class="auto-style34" style="margin-left: 25px;">&#10070; View </span></a>
                                    <a __designer:mapid="e" class="Viewcss" href="~/LabOnly/frmGapFinesSummaryReport.aspx" runat="server">
                                        <span class="auto-style34" style="margin-left: 35px;">&#20870; Report </span></a>

                                </p>
                            &nbsp;
                                <p>
                                    <a __designer:mapid="e" class="auto-style33"><span class="auto-style34">CRS Fines</span></a>
                                    <a __designer:mapid="e" class="Addcss" href="~/LabOnly/frmCRSFine.aspx" runat="server"><span class="auto-style34" style="margin-left: 150px;">&#43; Add </span></a>
                                    <a __designer:mapid="e" class="Viewcss" href="~/LabOnly/frmCRSFinesEdit.aspx" runat="server"><span class="auto-style34" style="margin-left: 25px;">&#10070; View </span></a>
                                    <a __designer:mapid="e" class="Viewcss" href="~/LabOnly/frmCRSFinesSummaryReport.aspx" runat="server"><span class="auto-style34" style="margin-left: 35px;">&#20870; Report </span></a>
                                </p>
                            &nbsp;
                                <p>
                                    <a __designer:mapid="e" class="auto-style33"><span class="auto-style34">ABF Fines</span></a>
                                    <a __designer:mapid="e" class="Addcss" href="~/LabOnly/frmABFFines.aspx" runat="server"><span class="auto-style34" style="margin-left: 150px;">&#43; Add </span></a>
                                    <a __designer:mapid="e" class="Viewcss" href="~/LabOnly/frmABFFinesEdit.aspx" runat="server"><span class="auto-style34" style="margin-left: 25px;">&#10070; View </span></a>
                                    <a __designer:mapid="e" class="Viewcss" href="~/LabOnly/frmABFFinesSummaryReport.aspx" runat="server"><span class="auto-style34" style="margin-left: 40px;">&#20870; Report </span></a>

                                </p>
                            &nbsp;
                                <p>
                                    <a __designer:mapid="e" class="auto-style33"><span class="auto-style34">ABF Packing Coke</span></a>
                                    <a __designer:mapid="e" class="Addcss" href="~/LabOnly/frmABFPackingCoke.aspx" runat="server"><span class="auto-style34" style="margin-left: 90px;">&#43; Add </span></a>
                                    <a __designer:mapid="e" class="Viewcss" href="~/LabOnly/frmABFPackingCokeEdit.aspx" runat="server"><span class="auto-style34" style="margin-left: 25px;">&#10070; View </span></a>
                                    <a __designer:mapid="e" class="Viewcss" href="~/LabOnly/frmABFPackingCokeSummaryReport.aspx" runat="server"><span class="auto-style34" style="margin-left: 40px;">&#20870; Report </span></a>
                                </p>
                            &nbsp;
                                <p>
                                    <a __designer:mapid="e" class="auto-style33"><span class="auto-style34">ACB(Anode Cover Bath)</span></a>
                                    <a __designer:mapid="e" class="Addcss" href="~/LabOnly/frmACB.aspx" runat="server"><span class="auto-style34" style="margin-left: 55px;">&#43; Add </span></a>
                                    <a __designer:mapid="e" class="Viewcss" href="~/LabOnly/frmACBEdit.aspx" runat="server"><span class="auto-style34" style="margin-left: 25px;">&#10070; View </span></a>
                                    <a __designer:mapid="e" class="Viewcss" href="~/LabOnly/frmACBSummaryReport.aspx" runat="server"><span class="auto-style34" style="margin-left: 35px;">&#20870; Report </span></a>
                                </p>
                            &nbsp;
                                <p>
                                    <a __designer:mapid="e" class="auto-style33"><span class="auto-style34">GAP J0120</span></a>
                                    <a __designer:mapid="e" class="Addcss" href="~/LabOnly/frmGAPButtAnalysis.aspx" runat="server"><span class="auto-style34" style="margin-left: 100px;">&#43; Add </span></a>
                                    <a __designer:mapid="e" class="Viewcss" href="~/LabOnly/frmGAPButtAnalysisEdit.aspx" runat="server"><span class="auto-style34" style="margin-left: 25px;">&#10070; View </span></a>
                                    <a __designer:mapid="e" class="Viewcss" href="~/LabOnly/frmGAPButtAnalysisSummaryReport.aspx" runat="server"><span class="auto-style34" style="margin-left: 35px;">&#20870; Report </span></a>
                                </p>
                            &nbsp;
                                <p>
                                    <a __designer:mapid="e" class="auto-style33"><span class="auto-style34">GAP CP Coke Physical</span></a>
                                    <a __designer:mapid="e" class="Addcss" href="~/LabOnly/frmGapCPCokePhysical.aspx" runat="server"><span class="auto-style34" style="margin-left: 65px;">&#43; Add </span></a>
                                    <a __designer:mapid="e" class="Viewcss" href="~/LabOnly/frmGapCPCokePhysicalEdit.aspx" runat="server"><span class="auto-style34" style="margin-left: 25px;">&#10070; View </span></a>
                                    <a __designer:mapid="e" class="Viewcss" href="~/LabOnly/frmGAPCPCokePhysicalSummaryReport.aspx" runat="server"><span class="auto-style34" style="margin-left: 35px;">&#20870; Report </span></a>
                                </p>
                            &nbsp;
                                <p>
                                    <a __designer:mapid="e" class="auto-style33"><span class="auto-style34">GAP Pitch Process</span></a>
                                    <a __designer:mapid="e" class="Addcss" href="~/LabOnly/frmGapPitchProcess.aspx" runat="server"><span class="auto-style34" style="margin-left: 100px;">&#43; Add </span></a>
                                    <a __designer:mapid="e" class="Viewcss" href="~/LabOnly/frmGapPitchProcessEdit.aspx" runat="server"><span class="auto-style34" style="margin-left: 25px;">&#10070; View </span></a>
                                    <a __designer:mapid="e" class="Viewcss" href="~/LabOnly/frmGAPPitchProcessSummaryReport.aspx" runat="server"><span class="auto-style34" style="margin-left: 30px;">&#20870; Report </span></a>
                                </p>
                             &nbsp;
                             <p>
                                    <a __designer:mapid="e" class="auto-style33"><span class="auto-style34">Baked Anode Analysis</span></a>
                                    <a __designer:mapid="e" class="Addcss" href="~/LabOnly/frmBakedAnodeAnalysis.aspx" runat="server"><span class="auto-style34" style="margin-left: 80px;">&#43; Add </span></a>
                                    <a __designer:mapid="e" class="Viewcss" href="~/LabOnly/frmBakedAnodeAnalysisEdit.aspx" runat="server"><span class="auto-style34" style="margin-left: 25px;">&#10070; View </span></a>
                                     <a __designer:mapid="e" class="Viewcss" href="~/LabOnly/frmBakedAnodeAnalysisSummaryReport.aspx" runat="server"><span class="auto-style34" style="margin-left: 25px;">&#20870; Report </span></a>

                                </p>
                             &nbsp;
                             <p>
                                    <a __designer:mapid="e" class="auto-style33"><span class="auto-style34">HTM Oil Analysis</span></a>
                                    <a __designer:mapid="e" class="Addcss" href="~/LabOnly/frmHTMOil.aspx" runat="server"><span class="auto-style34" style="margin-left: 120px;">&#43; Add </span></a>
                                    <a __designer:mapid="e" class="Viewcss" href="~/LabOnly/frmHTMOilEdit.aspx" runat="server"><span class="auto-style34" style="margin-left: 25px;">&#10070; View </span></a>
                                     <a __designer:mapid="e" class="Viewcss" href="~/LabOnly/frmHTMOilSummaryReport.aspx" runat="server"><span class="auto-style34" style="margin-left: 25px;">&#20870; Report </span></a>

                                </p>
                        </div>
                    </div>
                </div>



              




            </div>


            <!-- jQuery -->
           <%-- <script src="js/jquery.js" type="text/javascript"></script>
            <!-- Bootstrap Core JavaScript -->
            <script src="js/bootstrap.min.js" type="text/javascript"></script>
            <script src="js/wow.min.js" type="text/javascript"></script>
            <!-- Script to Activate the Carousel -->
            <script type="text/javascript">
                $('.carousel').carousel({
                    interval: 5000 //changes the speed
                })
            </script>--%>
            <script src="js/jquery/jquery-3.2.1.min.js"></script>
            <script src="js/bootstrap/js/popper.js"></script>
           <%-- <script src="js/bootstrap/js/bootstrap.min.js"></script>--%>
            <script src="js/countdowntime/moment.min.js"></script>
            <script src="js/countdowntime/moment-timezone.min.js"></script>
            <script src="js/countdowntime/moment-timezone-with-data.min.js"></script>
           <%-- <script src="js/countdowntime/countdowntime.js"></script>--%>
            <%--<script>
                $('.cd100').countdown100({
                    /*Set Endtime here*/
                    /*Endtime must be > current time*/
                    endtimeYear: 2018,
                    endtimeMonth: 11,
                    endtimeDate: 27,
                    endtimeHours: 07,
                    endtimeMinutes: 30,
                    endtimeSeconds: 0,
                    timeZone: ""
                });
            </script>--%>
           <%-- <script src="js/tilt/tilt.jquery.min.js"></script>
            <script>
                $('.js-tilt').tilt({
                    scale: 1.1
                })
            </script>--%>
        </div>
        <%--  end content--%>

        <!--- Footer  -->

           <!-- jQuery -->
            <script src="js/jquery.js" type="text/javascript"></script>
            <!-- Bootstrap Core JavaScript -->
            <%-- <script src="js/bootstrap.min.js" type="text/javascript"></script>--%>
            <%--  <script src="js/wow.min.js" type="text/javascript"></script>--%>
            <!-- Script to Activate the Carousel -->
            <%--<script type="text/javascript">
            $('#carousel').carousel({
                interval: 5000 //changes the speed
            })
        </script>--%>
            <script src="js/jquery/jquery-3.2.1.min.js"></script>
            <script src="js/bootstrap/js/popper.js"></script>
            <script src="js/bootstrap/js/bootstrap.min.js"></script>
            <script src="js/countdowntime/moment.min.js"></script>
            <script src="js/countdowntime/moment-timezone.min.js"></script>
            <script src="js/countdowntime/moment-timezone-with-data.min.js"></script>
            <script src="js/countdowntime/countdowntime.js"></script>
            <%-- <script>
            $('#cd100').countdown100({
                /*Set Endtime here*/
                /*Endtime must be > current time*/
                endtimeYear: 2018,
                endtimeMonth: 11,
                endtimeDate: 27,
                endtimeHours: 07,
                endtimeMinutes: 30,
                endtimeSeconds: 0,
                timeZone: ""
            });
        </script>
        <script src="js/tilt/tilt.jquery.min.js"></script>
        <script>
            $('.js-tilt').tilt({
                scale: 1.1
            })
        </script>--%>
        </div>

        <%--  end content--%>

        <!--- Footer  -->


        <footer id="footer">
            <!-- footer-widget-wrapper -->
            <div class="footer-widget-wrapper">
                <div class="container">
                    <div class="row">

                        <!-- footer-widget -->
                        <div class="col-md-3 col-sm-6">
                        </div>
                        <!-- footer-widget -->

                        <!-- footer-widget -->
                        <!-- footer-widget -->

                        <!-- footer-widget -->
                        <!-- footer-widget -->

                        <!-- footer-widget -->
                        <!-- footer-widget -->
                    </div>
                </div>
            </div>
            <!-- footer-widget-wrapper -->

            <!-- footer-bottom -->
            <div class="footer-bottom wow fadeInUp" data-wow-duration="1000ms" data-wow-delay="600ms">
                <div class="container">
                    <div class="row">


                        <div class="col-sm-7">
                            <div class="">
                                <p>Developed By<strong> :</strong> Domis Tech Pvt.Ltd</p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- footer-bottom -->
        </footer>
        <!--/#footer-->
        <!-- jQuery -->
        <script src="js/jquery.js" type="text/javascript"></script>
        <!-- Bootstrap Core JavaScript -->
        <%--   <script src="js/bootstrap.min.js" type="text/javascript"></script>--%>
        <script src="js/bootstrap.js" type="text/javascript"></script>
        <%--   <script src="js/wow.min.js" type="text/javascript"></script>--%>
        <!-- Script to Activate the Carousel -->
        <%--<script type="text/javascript">
            $('.carousel').carousel({
                interval: 5000 //changes the speed
            })
        </script>--%>
        <%-- <script>
            new WOW().init();
        </script>--%>
        <%--<script type="text/javascript">
            jQuery(document).ready(function () {
                var offset = 220;
                var duration = 500;
                jQuery(window).scroll(function () {
                    if (jQuery(this).scrollTop() > offset) {
                        jQuery('.back-to-top').fadeIn(duration);
                    } else {
                        jQuery('.back-to-top').fadeOut(duration);
                    }
                });

                jQuery('.back-to-top').click(function (event) {
                    event.preventDefault();
                    jQuery('html, body').animate({ scrollTop: 0 }, duration);
                    return false;
                })
            });
        </script>--%>
        <a href="#" class="back-to-top">UP</a>
    </form>
</body>
</html>