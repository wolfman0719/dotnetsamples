Class REST.Broker Extends %CSP.REST
{

XData UrlMap
{
<Routes>
<Route Url="/getcolors" Method="GET" Call="REST.JSON:GetColors"/>
</Routes>
}

}
