document.write('' + '<form name="calcForm">' + '<table cellpadding="2" cellspacing="3" border="0" valign="top" id="graybox" class="bodytext" width="100">' + '<tr bgcolor="#000066">' + '<td valign=top>' + '<div align=left><b><font face="Arial, Verdana, sans-serif" size="2" color="#FFFFFF">Currency Converter</font></b>' + '</div>' + '</td></tr>' + '<tr valign=top bgcolor="#FFFF33">' + '<td valign=top>' + '<div align="center">' + '<input type="Text" size=23 maxlength=60 name="outV" value="results go here" onFocus="blur()"></div>' + '</td>' + '<tr valign=top>' + '<td valign=top bgcolor="#FFFFFF">' + '<div align="center">' + '<select name="from" size="1" onChange="Cvalue()">' + '<option value="0">Euro</option>' + '<option value="1">Japanese Yen</option>' + '<option value="2">Pound Sterling</option>' + '<option value="3" selected>U.S. Dollar</option>' + '<option value="4">Argentine Peso</option>' + '<option value="5">Australian Dollar</option>' + '<option value="6">Bahrain Dinar</option>' + '<option value="7">Botswana Pula</option>' + '<option value="8">Brazilian Real</option>' + '<option value="9">Brunei Dollar</option>' + '<option value="10">Canadian Dollar</option>' + '<option value="11">Chilean Peso</option>' + '<option value="12">Chinese Yuan</option>' + '<option value="13">Colombian Peso</option>' + '<option value="14">Cyprus Pound</option>' + '<option value="15">Czech Koruna</option>' + '<option value="16">Danish Krone</option>' + '<option value="17">Hungarian Forint</option>' + '<option value="18">Icelandic Krona</option>' + '<option value="19">Indian Rupee</option>' + '<option value="20">Indonesian Rupiah</option>' + '<option value="21">Iranian Rial</option>' + '<option value="22">Israeli New Sheqel</option>' + '<option value="23">Korean Won</option>' + '<option value="24">Kuwaiti Dinar</option>' + '<option value="25">Libyan Dinar</option>' + '<option value="26">Malaysian Ringgit</option>' + '<option value="27">Maltese Lira</option>' + '<option value="28">Mauritian Rupee</option>' + '<option value="29">Mexican Peso</option>' + '<option value="30">Nepalese Rupee</option>' + '<option value="31">New Zealand Dollar</option>' + '<option value="32">Norwegian Krone</option>' + '<option value="33">Omani Rial</option>' + '<option value="34">Pakistan Rupee</option>' + '<option value="35">Polish Zloty</option>' + '<option value="36">Qatar Riyal</option>' + '<option value="37">Saudi Arabian Riyal</option>' + '<option value="38">Singapore Dollar</option>' + '<option value="39">Slovenian Tolar</option>' + '<option value="40">South African Rand</option>' + '<option value="41">Sri Lanka Rupee</option>' + '<option value="42">Swedish Krona</option>' + '<option value="43">Swiss Franc</option>' + '<option value="44">Thai Baht</option>' + '<option value="45">Trinidad & Tobago Dollar</option>' + '<option value="46">U.A.E. Dirham</option>' + '<option value="47">Venezuelan Bolivar</option>' + '</select>' + '</div>' + '</td>' + '<tr valign=top>' + '<td valign=top bgcolor="#FFFFFF">' + '<div align="center">' + '<select name="to" size=1 onChange="Cvalue()">' + '<option value="0">Euro</option>' + '<option value="1">Japanese Yen</option>' + '<option value="2">Pound Sterling</option>' + '<option value="3" selected>U.S. Dollar</option>' + '<option value="4">Argentine Peso</option>' + '<option value="5">Australian Dollar</option>' + '<option value="6">Bahrain Dinar</option>' + '<option value="7">Botswana Pula</option>' + '<option value="8">Brazilian Real</option>' + '<option value="9">Brunei Dollar</option>' + '<option value="10">Canadian Dollar</option>' + '<option value="11">Chilean Peso</option>' + '<option value="12">Chinese Yuan</option>' + '<option value="13">Colombian Peso</option>' + '<option value="14">Cyprus Pound</option>' + '<option value="15">Czech Koruna</option>' + '<option value="16">Danish Krone</option>' + '<option value="17">Hungarian Forint</option>' + '<option value="18">Icelandic Krona</option>' + '<option value="19">Indian Rupee</option>' + '<option value="20">Indonesian Rupiah</option>' + '<option value="21">Iranian Rial</option>' + '<option value="22">Israeli New Sheqel</option>' + '<option value="23">Korean Won</option>' + '<option value="24">Kuwaiti Dinar</option>' + '<option value="25">Libyan Dinar</option>' + '<option value="26">Malaysian Ringgit</option>' + '<option value="27">Maltese Lira</option>' + '<option value="28">Mauritian Rupee</option>' + '<option value="29">Mexican Peso</option>' + '<option value="30">Nepalese Rupee</option>' + '<option value="31">New Zealand Dollar</option>' + '<option value="32">Norwegian Krone</option>' + '<option value="33">Omani Rial</option>' + '<option value="34">Pakistan Rupee</option>' + '<option value="35">Polish Zloty</option>' + '<option value="36">Qatar Riyal</option>' + '<option value="37">Saudi Arabian Riyal</option>' + '<option value="38">Singapore Dollar</option>' + '<option value="39">Slovenian Tolar</option>' + '<option value="40">South African Rand</option>' + '<option value="41">Sri Lanka Rupee</option>' + '<option value="42">Swedish Krona</option>' + '<option value="43">Swiss Franc</option>' + '<option value="44">Thai Baht</option>' + '<option value="45">Trinidad & Tobago Dollar</option>' + '<option value="46">U.A.E. Dirham</option>' + '<option value="47">Venezuelan Bolivar</option>' + '</select>' + '</div>' + '</td>' + '<tr valign=top>' + '<td valign=top bgcolor="#FFFFFF">' + '<div align="center" class="rateText">Amount <input type="text" size=10 name="inV" value="1" onChange="javascript:Cvalue()"></div>' + '<div id="rateText" align="center" class="rateText">Rate: 0.00</div>' + '</td>' + '<tr valign=top>' + '<td valign=top bgcolor="#FFFFFF">' + '<div align="center">' + '<a href="#">' + '<img src="http://www.currencysource.com/images/button_convert.jpg" width="60" height="21" border="0" alt="Convert">' + '</a>' + '</div><br>' + '<div id="smlink" align="center">' + '<a href="http://currencysource.com" target="_blank"><i>Courtesy CurrencySource.com</i></a>' + '</div>' + '</td>' + '</table>' + '</form>	');