using GameProject.Business.Abstract;
using GameProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using MernisServiceReference;


namespace GameProject.Adapter
{
    public class MernisServiceAdapter : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var result = client.TCKimlikNoDogrulaAsync(gamer.IdentityNumber, gamer.Name, gamer.LastName, gamer.BirthYear).Result;
            return result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
