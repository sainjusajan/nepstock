<?php include ('header.php') ?>
<!--main content start-->
<section id="main-content">
    <section class="wrapper site-min-height">
        <!-- page start-->
        <section class="bread_crumb">
            <div class="row">
                <div class="col-md-6 col-sm-6">
                    <h3>Add New User</h3>
                </div>
                <!-- // col -->
                <div class="col-md-6 col-sm-6">
                    <ul class="crumbs">
                        <li><a href="index.php">Home</a></li>
                        <li> > </li>
                        <li>Add New User</li>
                    </ul>
                </div>
                <!-- // col -->
            </div>
            <!-- // row -->
        </section>
        <!-- // bread_crumb -->

        <section class="panel">
            <header class="panel-heading tab-bg-dark-navy-blue ">
                <ul class="nav nav-tabs">
                    <li class="active">
                        <a data-toggle="tab" href="#general" aria-expanded="true">General</a>
                    </li>
<!--
                    <li class="">
                        <a data-toggle="tab" href="#price" aria-expanded="false">Prices</a>
                    </li>
                    <li class="">
                        <a data-toggle="tab" href="#meta_info" aria-expanded="false">Meta Information</a>
                    </li>
                    <li class="">
                        <a data-toggle="tab" href="#product_images" aria-expanded="false">Images</a>
                    </li>
-->
                </ul>
            </header>
            <div class="panel-body">
                <form class="form-horizontal tasi-form" method="get">
                    <div class="form-group">
                        <label class="col-sm-2 col-sm-2 control-label">Default</label>
                        <div class="col-sm-10">
                            <input type="text" class="form-control">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-2 col-sm-2 control-label">Help text</label>
                        <div class="col-sm-10">
                            <input type="text" class="form-control">
                            <span class="help-block">A block of help text that breaks onto a new line and may extend beyond one line.</span>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-2 col-sm-2 control-label">Rounder</label>
                        <div class="col-sm-10">
                            <input type="text" class="form-control round-input">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-2 col-sm-2 control-label">Input focus</label>
                        <div class="col-sm-10">
                            <input class="form-control" id="focusedInput" type="text" value="This is focused...">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-2 col-sm-2 control-label">Disabled</label>
                        <div class="col-sm-10">
                            <input class="form-control" id="disabledInput" type="text" placeholder="Disabled input here..." disabled="">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-2 col-sm-2 control-label">Placeholder</label>
                        <div class="col-sm-10">
                            <input type="text" class="form-control" placeholder="placeholder">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-2 col-sm-2 control-label">Password</label>
                        <div class="col-sm-10">
                            <input type="password" class="form-control" placeholder="">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-lg-2 col-sm-2 control-label">Static control</label>
                        <div class="col-lg-10">
                            <p class="form-control-static">email@example.com</p>
                        </div>
                    </div>
                </form>

                <div class="tab-content">
                    <div id="general" class="tab-pane active">
                        <form class="m-t-30">
                            <div class="row">
                                <div class="col-md-6 col-sm-6">
                                    <!-- name of product -->
                                    <div class="form-group">
                                        <label for="title">Name of Product</label>
                                        <input type="title" class="form-control" id="title1" placeholder="">

                                    </div>
                                    <!-- name of product -->


                                    <!-- description -->
                                    <div class="form-group">

                                        <label for="title">Description</label>
                                        <textarea name="" id="input" class="form-control" rows="3" required="required"></textarea>
                                    </div>
                                    <!-- description -->


                                    <!-- short description -->
                                    <div class="form-group">

                                        <label for="title">Short Description</label>
                                        <textarea name="" id="input" class="form-control" rows="3" required="required"></textarea>
                                    </div>
                                    <!-- short description -->


                                    <!--SKU-->
                                    <div class="form-group">
                                        <label for="title">SKU</label>
                                        <input type="title" class="form-control" id="title1" placeholder="">

                                    </div>
                                    <!--SKU-->

                                    <!--weight-->
                                    <div class="form-group">
                                        <label for="title">Weight</label>
                                        <input type="title" class="form-control" id="title1" placeholder="">

                                    </div>
                                    <!--weight-->
                                    <!--country of manufacture-->
                                    <div class="form-group">
                                        <label for="product_type">country of manufacture</label>
                                        <select class="form-control select">

                                            <option value="AF">Afghanistan</option>
                                            <option value="AX">Åland Islands</option>
                                            <option value="AL">Albania</option>
                                            <option value="DZ">Algeria</option>
                                            <option value="AS">American Samoa</option>
                                            <option value="AD">Andorra</option>
                                            <option value="AO">Angola</option>
                                            <option value="AI">Anguilla</option>
                                            <option value="AQ">Antarctica</option>
                                            <option value="AG">Antigua and Barbuda</option>
                                            <option value="AR">Argentina</option>
                                            <option value="AM">Armenia</option>
                                            <option value="AW">Aruba</option>
                                            <option value="AU">Australia</option>
                                            <option value="AT">Austria</option>
                                            <option value="AZ">Azerbaijan</option>
                                            <option value="BS">Bahamas</option>
                                            <option value="BH">Bahrain</option>
                                            <option value="BD">Bangladesh</option>
                                            <option value="BB">Barbados</option>
                                            <option value="BY">Belarus</option>
                                            <option value="BE">Belgium</option>
                                            <option value="BZ">Belize</option>
                                            <option value="BJ">Benin</option>
                                            <option value="BM">Bermuda</option>
                                            <option value="BT">Bhutan</option>
                                            <option value="BO">Bolivia</option>
                                            <option value="BA">Bosnia and Herzegovina</option>
                                            <option value="BW">Botswana</option>
                                            <option value="BV">Bouvet Island</option>
                                            <option value="BR">Brazil</option>
                                            <option value="IO">British Indian Ocean Territory</option>
                                            <option value="VG">British Virgin Islands</option>
                                            <option value="BN">Brunei</option>
                                            <option value="BG">Bulgaria</option>
                                            <option value="BF">Burkina Faso</option>
                                            <option value="BI">Burundi</option>
                                            <option value="KH">Cambodia</option>
                                            <option value="CM">Cameroon</option>
                                            <option value="CA">Canada</option>
                                            <option value="CV">Cape Verde</option>
                                            <option value="KY">Cayman Islands</option>
                                            <option value="CF">Central African Republic</option>
                                            <option value="TD">Chad</option>
                                            <option value="CL">Chile</option>
                                            <option value="CN">China</option>
                                            <option value="CX">Christmas Island</option>
                                            <option value="CC">Cocos (Keeling) Islands</option>
                                            <option value="CO">Colombia</option>
                                            <option value="KM">Comoros</option>
                                            <option value="CG">Congo - Brazzaville</option>
                                            <option value="CD">Congo - Kinshasa</option>
                                            <option value="CK">Cook Islands</option>
                                            <option value="CR">Costa Rica</option>
                                            <option value="CI">Côte d’Ivoire</option>
                                            <option value="HR">Croatia</option>
                                            <option value="CU">Cuba</option>
                                            <option value="CY">Cyprus</option>
                                            <option value="CZ">Czech Republic</option>
                                            <option value="DK">Denmark</option>
                                            <option value="DJ">Djibouti</option>
                                            <option value="DM">Dominica</option>
                                            <option value="DO">Dominican Republic</option>
                                            <option value="EC">Ecuador</option>
                                            <option value="EG">Egypt</option>
                                            <option value="SV">El Salvador</option>
                                            <option value="GQ">Equatorial Guinea</option>
                                            <option value="ER">Eritrea</option>
                                            <option value="EE">Estonia</option>
                                            <option value="ET">Ethiopia</option>
                                            <option value="FK">Falkland Islands</option>
                                            <option value="FO">Faroe Islands</option>
                                            <option value="FJ">Fiji</option>
                                            <option value="FI">Finland</option>
                                            <option value="FR">France</option>
                                            <option value="GF">French Guiana</option>
                                            <option value="PF">French Polynesia</option>
                                            <option value="TF">French Southern Territories</option>
                                            <option value="GA">Gabon</option>
                                            <option value="GM">Gambia</option>
                                            <option value="GE">Georgia</option>
                                            <option value="DE">Germany</option>
                                            <option value="GH">Ghana</option>
                                            <option value="GI">Gibraltar</option>
                                            <option value="GR">Greece</option>
                                            <option value="GL">Greenland</option>
                                            <option value="GD">Grenada</option>
                                            <option value="GP">Guadeloupe</option>
                                            <option value="GU">Guam</option>
                                            <option value="GT">Guatemala</option>
                                            <option value="GG">Guernsey</option>
                                            <option value="GN">Guinea</option>
                                            <option value="GW">Guinea-Bissau</option>
                                            <option value="GY">Guyana</option>
                                            <option value="HT">Haiti</option>
                                            <option value="HM">Heard &amp; McDonald Islands</option>
                                            <option value="HN">Honduras</option>
                                            <option value="HK">Hong Kong SAR China</option>
                                            <option value="HU">Hungary</option>
                                            <option value="IS">Iceland</option>
                                            <option value="IN">India</option>
                                            <option value="ID">Indonesia</option>
                                            <option value="IR">Iran</option>
                                            <option value="IQ">Iraq</option>
                                            <option value="IE">Ireland</option>
                                            <option value="IM">Isle of Man</option>
                                            <option value="IL">Israel</option>
                                            <option value="IT">Italy</option>
                                            <option value="JM">Jamaica</option>
                                            <option value="JP">Japan</option>
                                            <option value="JE">Jersey</option>
                                            <option value="JO">Jordan</option>
                                            <option value="KZ">Kazakhstan</option>
                                            <option value="KE">Kenya</option>
                                            <option value="KI">Kiribati</option>
                                            <option value="KW">Kuwait</option>
                                            <option value="KG">Kyrgyzstan</option>
                                            <option value="LA">Laos</option>
                                            <option value="LV">Latvia</option>
                                            <option value="LB">Lebanon</option>
                                            <option value="LS">Lesotho</option>
                                            <option value="LR">Liberia</option>
                                            <option value="LY">Libya</option>
                                            <option value="LI">Liechtenstein</option>
                                            <option value="LT">Lithuania</option>
                                            <option value="LU">Luxembourg</option>
                                            <option value="MO">Macau SAR China</option>
                                            <option value="MK">Macedonia</option>
                                            <option value="MG">Madagascar</option>
                                            <option value="MW">Malawi</option>
                                            <option value="MY">Malaysia</option>
                                            <option value="MV">Maldives</option>
                                            <option value="ML">Mali</option>
                                            <option value="MT">Malta</option>
                                            <option value="MH">Marshall Islands</option>
                                            <option value="MQ">Martinique</option>
                                            <option value="MR">Mauritania</option>
                                            <option value="MU">Mauritius</option>
                                            <option value="YT">Mayotte</option>
                                            <option value="MX">Mexico</option>
                                            <option value="FM">Micronesia</option>
                                            <option value="MD">Moldova</option>
                                            <option value="MC">Monaco</option>
                                            <option value="MN">Mongolia</option>
                                            <option value="ME">Montenegro</option>
                                            <option value="MS">Montserrat</option>
                                            <option value="MA">Morocco</option>
                                            <option value="MZ">Mozambique</option>
                                            <option value="MM">Myanmar (Burma)</option>
                                            <option value="NA">Namibia</option>
                                            <option value="NR">Nauru</option>
                                            <option value="NP">Nepal</option>
                                            <option value="NL">Netherlands</option>
                                            <option value="AN">Netherlands Antilles</option>
                                            <option value="NC">New Caledonia</option>
                                            <option value="NZ">New Zealand</option>
                                            <option value="NI">Nicaragua</option>
                                            <option value="NE">Niger</option>
                                            <option value="NG">Nigeria</option>
                                            <option value="NU">Niue</option>
                                            <option value="NF">Norfolk Island</option>
                                            <option value="MP">Northern Mariana Islands</option>
                                            <option value="KP">North Korea</option>
                                            <option value="NO">Norway</option>
                                            <option value="OM">Oman</option>
                                            <option value="PK">Pakistan</option>
                                            <option value="PW">Palau</option>
                                            <option value="PS">Palestinian Territories</option>
                                            <option value="PA">Panama</option>
                                            <option value="PG">Papua New Guinea</option>
                                            <option value="PY">Paraguay</option>
                                            <option value="PE">Peru</option>
                                            <option value="PH">Philippines</option>
                                            <option value="PN">Pitcairn Islands</option>
                                            <option value="PL">Poland</option>
                                            <option value="PT">Portugal</option>
                                            <option value="PR">Puerto Rico</option>
                                            <option value="QA">Qatar</option>
                                            <option value="RE">Réunion</option>
                                            <option value="RO">Romania</option>
                                            <option value="RU">Russia</option>
                                            <option value="RW">Rwanda</option>
                                            <option value="BL">Saint Barthélemy</option>
                                            <option value="SH">Saint Helena</option>
                                            <option value="KN">Saint Kitts and Nevis</option>
                                            <option value="LC">Saint Lucia</option>
                                            <option value="MF">Saint Martin</option>
                                            <option value="PM">Saint Pierre and Miquelon</option>
                                            <option value="WS">Samoa</option>
                                            <option value="SM">San Marino</option>
                                            <option value="ST">São Tomé and Príncipe</option>
                                            <option value="SA">Saudi Arabia</option>
                                            <option value="SN">Senegal</option>
                                            <option value="RS">Serbia</option>
                                            <option value="SC">Seychelles</option>
                                            <option value="SL">Sierra Leone</option>
                                            <option value="SG">Singapore</option>
                                            <option value="SK">Slovakia</option>
                                            <option value="SI">Slovenia</option>
                                            <option value="SB">Solomon Islands</option>
                                            <option value="SO">Somalia</option>
                                            <option value="ZA">South Africa</option>
                                            <option value="GS">South Georgia &amp; South Sandwich Islands</option>
                                            <option value="KR">South Korea</option>
                                            <option value="ES">Spain</option>
                                            <option value="LK">Sri Lanka</option>
                                            <option value="VC">St. Vincent &amp; Grenadines</option>
                                            <option value="SD">Sudan</option>
                                            <option value="SR">Suriname</option>
                                            <option value="SJ">Svalbard and Jan Mayen</option>
                                            <option value="SZ">Swaziland</option>
                                            <option value="SE">Sweden</option>
                                            <option value="CH">Switzerland</option>
                                            <option value="SY">Syria</option>
                                            <option value="TW">Taiwan</option>
                                            <option value="TJ">Tajikistan</option>
                                            <option value="TZ">Tanzania</option>
                                            <option value="TH">Thailand</option>
                                            <option value="TL">Timor-Leste</option>
                                            <option value="TG">Togo</option>
                                            <option value="TK">Tokelau</option>
                                            <option value="TO">Tonga</option>
                                            <option value="TT">Trinidad and Tobago</option>
                                            <option value="TN">Tunisia</option>
                                            <option value="TR">Turkey</option>
                                            <option value="TM">Turkmenistan</option>
                                            <option value="TC">Turks and Caicos Islands</option>
                                            <option value="TV">Tuvalu</option>
                                            <option value="UG">Uganda</option>
                                            <option value="UA">Ukraine</option>
                                            <option value="AE">United Arab Emirates</option>
                                            <option value="GB">United Kingdom</option>
                                            <option value="US">United States</option>
                                            <option value="UY">Uruguay</option>
                                            <option value="UM">U.S. Outlying Islands</option>
                                            <option value="VI">U.S. Virgin Islands</option>
                                            <option value="UZ">Uzbekistan</option>
                                            <option value="VU">Vanuatu</option>
                                            <option value="VA">Vatican City</option>
                                            <option value="VE">Venezuela</option>
                                            <option value="VN">Vietnam</option>
                                            <option value="WF">Wallis and Futuna</option>
                                            <option value="EH">Western Sahara</option>
                                            <option value="YE">Yemen</option>
                                            <option value="ZM">Zambia</option>
                                            <option value="ZW">Zimbabwe</option>
                                        </select>

                                    </div>
                                    <!--country of manufacture-->





                                </div>
                                <div class="col-md-6 col-sm-6">


                                    <!--attribute set-->
                                    <div class="form-group">
                                        <label for="attribute_set">Attribute Set</label>
                                        <select class="form-control">
                                            <option>Women</option>
                                            <option>Men</option>
                                            <option>Electronics</option>
                                            <option>Home & living</option>
                                            <option>Health & fitness</option>
                                            <option>Grocery & Crocery</option>
                                            <option>Kids</option>
                                            <option>Pet Supplies</option>
                                        </select>
                                    </div>
                                    <!--attribute set-->


                                    <!--product type-->
                                    <div class="form-group">
                                        <label for="product_type">Product type</label>
                                        <select class="form-control">
                                            <option value="simple">Simple Product</option>
                                            <option value="grouped">Grouped Product</option>
                                            <option value="configurable">Configurable Product</option>
                                            <option value="virtual">Virtual Product</option>
                                            <option value="bundle">Bundle Product</option>
                                            <option value="downloadable">Downloadable Product</option>
                                        </select>

                                    </div>
                                    <!--product type-->

                                    <!-- Set Product as New from date -->
                                    <div class="form-group">

                                        <label for="title">Set Product as New from date</label>

                                        <input type="date" name="" id="input" class="form-control" value="" required="required" title="">

                                    </div>
                                    <!-- Set Product as New from date -->


                                    <!-- Set Product as New to date -->
                                    <div class="form-group">

                                        <label for="title">Set Product as New to date</label>

                                        <input type="date" name="" id="input" class="form-control" value="" required="required" title="">

                                    </div>
                                    <!-- Set Product as New to date -->



                                    <!--status-->
                                    <div class="form-group">
                                        <label for="product_type">Status</label>
                                        <select class="form-control">
                                            <option value="simple">Enabled</option>
                                            <option value="simple">Disabled</option>

                                        </select>

                                    </div>
                                    <!--status-->

                                    <!--visibility-->
                                    <div class="form-group">
                                        <label for="product_type">Visibility</label>
                                        <select class="form-control">
                                            <option value="1">Not Visible Individually</option>
                                            <option value="2">Catalog</option>
                                            <option value="3">Search</option>
                                            <option value="4">Catalog, Search</option>
                                        </select>

                                    </div>
                                    <!--visibility-->
                                    <!--manufacturer-->
                                    <div class="form-group">
                                        <label for="product_type">Manufacturer</label>
                                        <select class="form-control">

                                            <option value="33">BrandLogo</option>
                                            <option value="25">Brandisimi</option>
                                            <option value="18">SampleManufacturer</option>
                                            <option value="12">TheBrand</option>
                                            <option value="24">BlueLogo</option>
                                            <option value="26">Publisher</option>
                                            <option value="13" selected="selected">Company</option>
                                            <option value="31">Soundwave</option>
                                            <option value="23">LogoFashion</option>
                                            <option value="11">Samsung</option>
                                            <option value="10">Apple</option>
                                        </select>

                                    </div>
                                    <!--manufacturer-->



                                </div>
                                <!-- // col -->
                            </div>
                            <!-- // row -->

                            <div class="text-right">

                                <a href="news.php" class="btn btn-warning"><i class="fa fa-arrow-left m-r-5"></i>Go Back</a>
                                <button class="btn btn-success" type="submit"><i class="fa fa-paper-plane-o m-r-5"></i>Submit</button>


                            </div>

                        </form>


                    </div>
                    <div id="price" class="tab-pane">
                        <form class="m-t-30">
                            <div class="row">
                                <div class="col-md-6 col-sm-6">
                                    <!-- price -->
                                    <div class="form-group">
                                        <label for="title">Price</label>
                                        <input type="title" class="form-control" id="title1" placeholder="">

                                    </div>
                                    <!-- price -->

                                    <!--special price -->
                                    <div class="form-group">
                                        <label for="title">Price</label>
                                        <input type="title" class="form-control" id="title1" placeholder="">

                                    </div>
                                    <!--special price -->


                                    <!-- special price from date -->
                                    <div class="form-group">

                                        <label for="title">Set Product as New from date</label>

                                        <input type="date" name="" id="input" class="form-control" value="" required="required" title="">

                                    </div>
                                    <!-- Set Product as New from date -->


                                    <!-- special price to date -->
                                    <div class="form-group">

                                        <label for="title">Set Product as New to date</label>

                                        <input type="date" name="" id="input" class="form-control" value="" required="required" title="">

                                    </div>
                                    <!-- Set Product as New to date -->

                                </div>
                                <div class="col-md-6 col-sm-6">
                                    <!-- apply map -->
                                    <div class="form-group">
                                        <label for="title">Apply MAP</label>
                                        <select class="form-control">
                                            <option value="1">Yes</option>
                                            <option value="0">No</option>
                                            <option value="2">Use config</option>
                                        </select>


                                    </div>
                                    <!-- apply map-->
                                    <!-- Display Actual Price -->
                                    <div class="form-group">
                                        <label for="title">Display Actual Price</label>
                                        <select class="form-control">
                                            <option value="2">In Cart</option>
                                            <option value="3">Before Order Confirmation</option>
                                            <option value="1">On Gesture</option>
                                            <option value="4">Use config</option>
                                        </select>


                                    </div>
                                    <!-- Display Actual Price-->


                                    <!--Manufacturer's Suggested Retail Price -->
                                    <div class="form-group">
                                        <label for="title">Manufacturer's Suggested Retail Price</label>
                                        <input type="title" class="form-control" id="title1" placeholder="">

                                    </div>
                                    <!--Manufacturer's Suggested Retail Price -->


                                    <!-- Tax Class -->
                                    <div class="form-group">
                                        <label for="title">Tax Class</label>
                                        <select class="form-control">
                                            <option value="0">None</option>
                                            <option value="2">Taxable Goods</option>
                                            <option value="4">Shipping</option>
                                        </select>


                                    </div>
                                    <!-- Tax Class-->



                                </div>
                            </div>
                        </form>

                    </div>
                    <div id="meta_info" class="tab-pane">
                        <form class="m-t-30">
                            <div class="row">
                                <div class="col-md-6 col-sm-6">
                                    <!-- Meta title -->
                                    <div class="form-group">
                                        <label for="title">Meta Title</label>
                                        <input type="title" class="form-control" id="title1" placeholder="">

                                    </div>
                                    <!-- Meta title -->

                                    <!-- Meta keywords -->
                                    <div class="form-group">

                                        <label for="title">Meta keywords</label>
                                        <textarea name="" id="input" class="form-control" rows="3" required="required"></textarea>
                                    </div>
                                    <!-- Meta keywords -->


                                </div>
                                <div class="col-md-6 col-sm-6">
                                    <!-- Meta description -->
                                    <div class="form-group">

                                        <label for="title">Meta Description</label>
                                        <textarea name="" id="input" class="form-control" rows="3" required="required"></textarea>
                                    </div>
                                    <!-- Meta description -->

                                </div>
                            </div>
                        </form>


                    </div>
                    <div id="product_images" class="tab-pane">

                        <form class="m-t-30">
                            <div class="row">
                                <div class="col-md-6 col-sm-6">

                                    <div class="form-group">

                                        <label for="title">Upload image/images</label>
                                        <input type="file" name="img" multiple>

                                        <button type="submit" class="btn btn-success m-t-15">Upload</button>



                                    </div>

                                </div>
                                <div class="col-md-6 col-sm-6">

                                </div>
                            </div>
                        </form>
                    </div>
                </div>
            </div>
        </section>



        <!-- page end-->
    </section>
    <!-- // wrapper -->
</section>
<!-- main content -->
<!--main content end-->

<?php include ('footer.php') ?>
