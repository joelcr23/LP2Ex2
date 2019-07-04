package pe.edu.pucp.inf.lp2.servlets;

import java.io.IOException;
import java.io.PrintWriter;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

public class ServletPrueba extends HttpServlet {
    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        
        
        
        int numero1 = Integer.parseInt(
                request.getParameter
        ("txtNumero1").toString());
        int numero2 = Integer.parseInt(
                request.getParameter
        ("txtNumero2").toString());
        int resultado = numero1 * numero2;
        PrintWriter out = response.getWriter();
        out.print("El resultado es: "+resultado);
    }
}
