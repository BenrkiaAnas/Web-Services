import proxy.BanqueService;
import proxy.BanqueWS;
import proxy.Compte;

import java.util.List;

public class ClientWS {
    public static void main(String[] args) {
        BanqueService stubWS = new BanqueWS().getBanqueServicePort();
        System.out.println(stubWS.conversionEuroToDH(800));
        Compte cp = stubWS.getCompte(2L);
        System.out.println(cp.getCode());
        System.out.println(cp.getSolde());
        List<Compte> cptes = stubWS.listeComptes();
        cptes.forEach(c -> {
            System.out.println("------------");
            System.out.println(cp.getCode());
            System.out.println(cp.getSolde());
        });
    }
}
