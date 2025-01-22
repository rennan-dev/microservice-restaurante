using RestauranteService.Dtos;

namespace RestauranteService.RabbitMqClient;

public interface IRabbitMQ {
    void PublicaRestaurante(RestauranteReadDto restauranteReadDto);
}