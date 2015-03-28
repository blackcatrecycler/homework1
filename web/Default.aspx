<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
             <!-- header -->
		<div class="head-bg">
			<div class="header">
				<!-- container -->
				<div class="container">
					<div class="head-logo">
						<a href="#"><img src="./images/logo.png" alt="" /></a>
					</div>
					<!-- banner Slider starts Here -->
					<script src="./js/responsiveslides.min.js"></script>
					 <script>
					     // You can also use "$(window).load(function() {"
					     $(function () {
					         // Slideshow 4
					         $("#slider4").responsiveSlides({
					             auto: true,
					             pager: true,
					             nav: false,
					             speed: 500,
					             namespace: "callbacks",
					             before: function () {
					                 $('.events').append("<li>before event fired.</li>");
					             },
					             after: function () {
					                 $('.events').append("<li>after event fired.</li>");
					             }
					         });

					     });
					  </script>
					<!--//End-slider-script -->
					<div  id="Div1" class="callbacks_container">
						<ul class="rslides" id="slider4">
							<li>
								<div class="head-info">
									<span><img src="./images/mobile.png" alt="" /> </span>
									<div class="head-text">
										<h1>Awesome Design</h1>
										<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco labornisi ut aliquip ex ea commodo consequa</p>
										<div class="button">
											<a href="#">DOWNLOAD</a>
										</div>
									</div>
									<div class="mobile-device">
										<img src="./images/mobile.png" alt="" />
									</div>
									<div class="clearfix"> </div>
								</div>
							</li>
							<li>
								<div class="head-info">
									<span><img src="./images/mobile.png" alt="" /> </span>
									<div class="head-text">
										<h1>Beautiful Design</h1>
										<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco labornisi ut aliquip ex ea commodo consequa</p>
										<div class="button">
											<a href="#">DOWNLOAD</a>
										</div>
									</div>
									<div class="mobile-device">
										<img src="./images/mobile.png" alt="" />
									</div>
									<div class="clearfix"> </div>
								</div>
							</li><li>
								<div class="head-info">
									<span><img src="./images/mobile.png" alt="" /> </span>
									<div class="head-text">
										<h1>Awesome Design</h1>
										<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco labornisi ut aliquip ex ea commodo consequa</p>
										<div class="button">
											<a href="#">DOWNLOAD</a>
										</div>
									</div>
									<div class="mobile-device">
										<img src="./images/mobile.png" alt="" />
									</div>
									<div class="clearfix"> </div>
								</div>
							</li>
						</ul>
						<div class="clearfix"> </div>
						<!-- banner Slider Ends Here --> 
					</div>
					<div class="clearfix"> </div>
				</div>
				<!-- //container -->
			</div>
		</div>  

            <div class="welcome-note">
			<h2>Welcome To elsta</h2>
			<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit
				sed do eiusmod tempor incididunt ut labore et dolore magna aliqua</p>
		</div>
		<!-- welcome-note -->
		<!-- app -->
		<div class="app">
			<!-- container -->
			<div class="container">
				<div class="col-md-6 app-left">
					<h3>Get The App</h3>
					<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequa</p>
					<div class="button">
						<a href="#">DOWNLOAD</a>
					</div>
				</div>
				<div class="col-md-6">
					<iframe src="//player.vimeo.com/video/35839668" frameborder="0" webkitallowfullscreen mozallowfullscreen allowfullscreen></iframe> 
				</div>
				<div class="clearfix"> </div>
			</div>
			<!-- //container -->
		</div>
    <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
		<!-- //app -->
		<!-- app-bottom -->
		<div class="app-bottom">
			<!-- container -->
			<div class="container">
				<div class="bottom-grids">
					<div class="col-md-3 bottom-grid">
						<img src="./images/rocket.png" alt="" />
						<div class="border"> </div>
						<h4>Great concept</h4>
						<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit</p>
					</div>
					<div class="col-md-3 bottom-grid">
						<img src="./images/user.png" alt="" />
						<div class="border"> </div>
						<h4>Great concept</h4>
						<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit</p>
					</div>
					<div class="col-md-3 bottom-grid">
						<img src="./images/setting.png" alt="" />
						<div class="border"> </div>
						<h4>Great concept</h4>
						<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit</p>
					</div>
					<div class="col-md-3 bottom-grid">
						<img src="./images/lock.png" alt="" />
						<div class="border"> </div>
						<h4>Great concept</h4>
						<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit</p>
					</div>
					<div class="clearfix"> </div>
				</div>
			</div>
			<!-- //container -->
		</div>
            </ItemTemplate>
        </asp:Repeater>
		<!-- app-bottom -->
		<!-- team -->
   <asp:Repeater ID="team1" runat="server">
      <ItemTemplate>
		<div class="team">
			<!-- container -->
			<div class="container">
				<script>
				    // You can also use "$(window).load(function() {"
				    $(function () {
				        // Slideshow 4
				        $("#slider3").responsiveSlides({
				            auto: true,
				            pager: true,
				            nav: false,
				            speed: 500,
				            namespace: "callbacks",
				            before: function () {
				                $('.events').append("<li>before event fired.</li>");
				            },
				            after: function () {
				                $('.events').append("<li>after event fired.</li>");
				            }
				        });

				    });
					  </script>
					  <div  id="top" class="callbacks_container">
						<ul class="rslides" id="slider3">		
                            <li>
								<img src="./images/ceo.png" alt="" />
								<p>John Smith, CEO</p>
								<div class="u-coma">
									<img src="./images/u-coma.png" alt="" />
								</div>
								<p class="subtext">Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequa</p>
								<div class="d-coma">
									<img src="./images/d-coma.png" alt="" />
								</div>
							</li>
							<li>
								<img src="./images/2.png" alt="" />
								<p>MELISSA DOE,Director</p>
								<div class="u-coma">
									<img src="./images/u-coma.png" alt="" />
								</div>
								<p class="subtext">Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequa</p>
								<div class="d-coma">
									<img src="./images/d-coma.png" alt="" />
								</div>
							</li>
							<li>
								<img src="./images/3.png" alt="" />
								<p>Angelica, Designer</p>
								<div class="u-coma">
									<img src="./images/u-coma.png" alt="" />
								</div>
								<p class="subtext">Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequa</p>
								<div class="d-coma">
									<img src="./images/d-coma.png" alt="" />
								</div>
							</li>
						</ul>

					</div>
			</div>
			
			<!-- //container -->
		</div>
          </ItemTemplate>
          </asp:Repeater>
		<!-- //team -->
		<!-- plans -->
		<div class="plans">
			<!-- container -->
			<div class="container">
				<h3>Pricing Plans</h3>
				<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. </p>
				<div class="plans-grids">
					<div class="plans-grid">
						<div class="plan-text">
							<a href="#">$ <span>25</span></a>
							<p>/month</p>
						</div>
						<div class="plans-grid-bottom">
							<div class="plans-grid-head">
								<h4>Basic</h4>
								<span>Description goes here</span>
							</div>
							<p>Feature 1</p>
							<p>Feature 2</p>
							<p>Feature 3</p>
							<p>Feature 4</p>
							<div class="plan-button">
								<a class="signup play-icon popup-with-zoom-anim" href="#small-dialog2">Purchase</a>
							</div>
						</div>
					</div>
					<div class="plans-grid">
						<div class="plan-text">
							<a href="#">$ <span>50</span></a>
							<p>/month</p>
						</div>
						<div class="plans-grid-bottom">
							<div class="plans-grid-head">
								<h4>Standard</h4>
								<span>Description goes here</span>
							</div>
							<p>Feature 1</p>
							<p>Feature 2</p>
							<p>Feature 3</p>
							<p>Feature 4</p>
							<div class="plan-button">
								<a class="signup play-icon popup-with-zoom-anim" href="#small-dialog2">Purchase</a>
							</div>
						</div>
					</div>
					<div class="plans-grid">
						<div class="plan-text">
							<a href="#">$ <span>75</span></a>
							<p>/month</p>
						</div>
						<div class="plans-grid-bottom">
							<div class="plans-grid-head">
								<h4>Deluxe</h4>
								<span>Description goes here</span>
							</div>
							<p>Feature 1</p>
							<p>Feature 2</p>
							<p>Feature 3</p>
							<p>Feature 4</p>
							<div class="plan-button">
								<a class="signup play-icon popup-with-zoom-anim" href="#small-dialog2">Purchase</a>
							</div>
						</div>
					</div>
					<div class="plans-grid">
						<div class="plan-text">
							<a href="#">$ <span>99</span></a>
							<p>/month</p>
						</div>
						<div class="plans-grid-bottom">
							<div class="plans-grid-head">
								<h4>Premium</h4>
								<span>Description goes here</span>
							</div>
							<p>Feature 1</p>
							<p>Feature 2</p>
							<p>Feature 3</p>
							<p>Feature 4</p>
							<div class="plan-button">
								<a class="signup play-icon popup-with-zoom-anim" href="#small-dialog2">Purchase</a>
								<!-- script-for-menu -->
									 <script>
									     $("span.menu").click(function () {
									         $("ul.nav1").slideToggle(300, function () {
									             // Animation complete.
									         });
									     });
									</script>
								<!-- /script-for-menu -->
							</div>
						</div>
					</div>
					<div class="clearfix"> </div>
				</div>
			</div>
			<!-- //container -->
		</div>
		<!-- //plans -->
		<!-- pop-up-box -->
				<script type="text/javascript" src="./js/modernizr.custom.min.js"></script>    
				<link href="./css/popuo-box.css" rel="stylesheet" type="text/css" media="all" />
				<script src="./js/jquery.magnific-popup.js" type="text/javascript"></script>
			<!--//pop-up-box -->
			<div id="small-dialog2" class="mfp-hide">
					<div class="signup">
						<h3>Online Shipping</h3>
						<input type="text" placeholder="First Name" required=""/>
						<input type="text" placeholder="Second Name" required=""/>
						<input type="text" placeholder="Email" required=""/>
						<input type="text" placeholder="Phone" required=""/>						
						<input type="text" class="email" placeholder="Address" required=""/>
						<h4>Payment</h4>
						<input type="text" placeholder="Card Number" required=""/>
						<input type="text" placeholder="Card Name" required=""/>
						<input type="text" placeholder="Date of expired" required=""/>
						<input type="text" placeholder="CNN" required=""/>			
						<input type="submit" value="PROCEED"/>
					</div>
				</div>	

			<script>
			    $(document).ready(function () {
			        $('.popup-with-zoom-anim').magnificPopup({
			            type: 'inline',
			            fixedContentPos: false,
			            fixedBgPos: true,
			            overflowY: 'auto',
			            closeBtnInside: true,
			            preloader: false,
			            midClick: true,
			            removalDelay: 300,
			            mainClass: 'my-mfp-zoom-in'
			        });

			    });
				</script>	

		<!-- contact -->
		<div class="contact">
			<!-- //container -->
			<div class="container">
				<div class="contact-info">
					<h3>Contact Us</h3>
					<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit </p>
					<div class="text-fields-left">
						<div class="text-field-email">
							<form>
								<input type="text" placeholder="Name" required=""/>
							</form>
						</div>
						<div class="text-field-name">
							<form>
								<input type="text" placeholder="Email" required=""/>
							</form>
						</div>
						<div class="clearfix"> </div>
						<div class="text-field-area ">
							<form>
								<textarea placeholder="Message....." required=""></textarea>
								<input type="submit" value="SEND"/>
							</form>
							<div class="pen-img"></div>
						</div>
					</div>
				</div>
			</div>
			<!-- //container -->
		</div>
		<!-- //contact -->
		<!-- footer -->


</asp:Content>

