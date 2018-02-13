<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl">
  <xsl:output method="html" indent="yes"/>
  <xsl:template match="/*">
    <html>
    <head>
        <style type="text/css">
          .bb
          {
          border-bottom: solid 1px black;
          }
          .title 
          { 
            font-size:26px; 
          }
          tr.border_bottom td 
          {
            border-bottom:1pt solid black; 
          }
          .Hname 
          {
            text-align:left; font-size:20px; color:#00008B; font-family:Arial;
          }
          .Pname 
          {
            font-size:15px; color:#00008B; font-family:Times New Roman;
          }
          .Pname2 
          {
            font-size:20px; font-family:Tahoma;  
          }
        </style>
      <title>Hotels</title>
    </head>
    <body>
      <h1 height="30px" class="title">Hotels In Narnia Area</h1>
      <table width="90%" border="1" rules="all" bordercolor="#00008B">
        <tr bgcolor="#ccefff">
          <td height="40" class="bb" width="20%" align="center">
            <p class="Pname2"><b>Name</b></p>
          </td>
          <td class="bb" width="10%" align="center"><p class="Pname2"><b>Rating</b></p>
          </td>
          <td class="bb" align="center">
            <p class="Pname2"><b>Average Price Per Night</b></p>
          </td>
        </tr>
      </table>
	  
   
      <?php
		 if ($_GET['submit'])
  {         
    ?>
      <xsl:apply-templates select="HotelsList">
        <xsl:sort select="name"/>
      </xsl:apply-templates>

      <?php
  } else { 
   ?>

      <xsl:apply-templates select="HotelsList">
        <xsl:sort select="rating" data-type="number" order="descending"/>
      </xsl:apply-templates>
      <?php
  
 
  }
	  ?>

      <FORM method="get" action=" Assignment2.html">
        <input type="submit" value=" Submit "></input>
        <input type="hidden" name="desencing" value="true"></input>
      </FORM>
    </body> 
    </html> 
  </xsl:template>
  <xsl:template match="HotelsList">
    <table width="90%" border ="1" rules="all" cellpadding="10">
      <tr width="80%" height="50">
        <td width="20%">
          <p class="Hname">
            <xsl:value-of select="name"/>
          </p>
        </td>
        <td width="10%" align="center">
          <xsl:if test="rating=5.0">
            <img src="../../img/FiveStars.jpg" width="100" height="25"/>
          </xsl:if>
          <xsl:if test="rating=4.5">
            <img src="../../img/fourandhalf.jpg" width="100" height="25"/>
          </xsl:if>
          <xsl:if test="rating=4.0">
            <img src="../../img/four.jpg" width="100" height="25"/>
          </xsl:if>
          <xsl:if test="rating=3.5">
            <img src="../../img/threeandhalf.jpg" width="100" height="25"/>
          </xsl:if>
          <xsl:if test="rating=3.0">
            <img width="100" height="25" src="../../img/three.jpg"/>
          </xsl:if>
          <xsl:if test="rating=2.5">
            <img src="../../img/twoandhalf.jpg" width="100" height="25" />
          </xsl:if>
          <xsl:if test="rating=2.0">
            <img width="100" height="25" src="../../img/two.jpg"/>
          </xsl:if>
          <xsl:if test="rating=1.5">
            <img width="100" height="25" src="../../img/oneandhalf.jpg"/>
          </xsl:if>
       </td>
        <td width="70%" align="center">
          <table width="100%" border="1" rules="all" bordercolor="grey" cellspacing="0" cellpadding="1">
            <tr>
              <xsl:for-each select="RoomTypes/Room">
                <td width="25%" height="30" align="center">
                  <p class="Pname" >
                  <xsl:value-of select="concat(id, ' = $', rate)" />
                  </p>
                </td>
              </xsl:for-each> 
            </tr>
            <tr>
            </tr>
          </table>
        </td>
      </tr> 
    </table>  
  </xsl:template>
</xsl:stylesheet>