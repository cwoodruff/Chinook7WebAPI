﻿using Chinook.Domain.ApiModels;
using Chinook.Domain.Extensions;

namespace Chinook.Domain.Supervisor;

public interface IChinookSupervisor
{
    Task<PagedList<AlbumApiModel>> GetAllAlbum(int pageNumber, int pageSize);
    Task<AlbumApiModel?> GetAlbumById(int id);
    Task<PagedList<AlbumApiModel>> GetAlbumByArtistId(int id, int pageNumber, int pageSize);

    Task<AlbumApiModel> AddAlbum(AlbumApiModel newAlbumApiModel);

    Task<bool> UpdateAlbum(AlbumApiModel albumApiModel);
    Task<bool> DeleteAlbum(int id);
    Task<PagedList<ArtistApiModel>> GetAllArtist(int pageNumber, int pageSize);
    Task<ArtistApiModel> GetArtistById(int id);

    Task<ArtistApiModel> AddArtist(ArtistApiModel newArtistApiModel);

    Task<bool> UpdateArtist(ArtistApiModel artistApiModel);

    Task<bool> DeleteArtist(int id);
    Task<PagedList<CustomerApiModel>> GetAllCustomer(int pageNumber, int pageSize);
    Task<CustomerApiModel> GetCustomerById(int id);

    Task<PagedList<CustomerApiModel>> GetCustomerBySupportRepId(int id, int pageNumber, int pageSize);

    Task<CustomerApiModel> AddCustomer(CustomerApiModel newCustomerApiModel);

    Task<bool> UpdateCustomer(CustomerApiModel customerApiModel);

    Task<bool> DeleteCustomer(int id);
    Task<PagedList<EmployeeApiModel>> GetAllEmployee(int pageNumber, int pageSize);
    Task<EmployeeApiModel?> GetEmployeeById(int id);
    Task<EmployeeApiModel?> GetEmployeeReportsTo(int id);

    Task<EmployeeApiModel> AddEmployee(EmployeeApiModel newEmployeeApiModel);

    Task<bool> UpdateEmployee(EmployeeApiModel employeeApiModel);

    Task<bool> DeleteEmployee(int id);

    Task<IEnumerable<EmployeeApiModel>> GetEmployeeDirectReports(int id);

    Task<IEnumerable<EmployeeApiModel>> GetDirectReports(int id);
    Task<PagedList<GenreApiModel>> GetAllGenre(int pageNumber, int pageSize);
    Task<GenreApiModel?> GetGenreById(int id);

    Task<GenreApiModel> AddGenre(GenreApiModel newGenreApiModel);

    Task<bool> UpdateGenre(GenreApiModel genreApiModel);
    Task<bool> DeleteGenre(int id);
    Task<PagedList<InvoiceLineApiModel>> GetAllInvoiceLine(int pageNumber, int pageSize);
    Task<InvoiceLineApiModel> GetInvoiceLineById(int id);

    Task<PagedList<InvoiceLineApiModel>> GetInvoiceLineByInvoiceId(int id, int pageNumber, int pageSize);

    Task<PagedList<InvoiceLineApiModel>> GetInvoiceLineByTrackId(int id, int pageNumber, int pageSize);

    Task<InvoiceLineApiModel> AddInvoiceLine(InvoiceLineApiModel newInvoiceLineApiModel);

    Task<bool> UpdateInvoiceLine(InvoiceLineApiModel invoiceLineApiModel);

    Task<bool> DeleteInvoiceLine(int id);
    Task<PagedList<InvoiceApiModel>> GetAllInvoice(int pageNumber, int pageSize);
    Task<InvoiceApiModel?> GetInvoiceById(int id);

    Task<PagedList<InvoiceApiModel>> GetInvoiceByCustomerId(int id, int pageNumber, int pageSize);

    Task<InvoiceApiModel> AddInvoice(InvoiceApiModel newInvoiceApiModel);

    Task<bool> UpdateInvoice(InvoiceApiModel invoiceApiModel);

    Task<bool> DeleteInvoice(int id);

    Task<PagedList<InvoiceApiModel>> GetInvoiceByEmployeeId(int id, int pageNumber, int pageSize);

    Task<PagedList<MediaTypeApiModel>> GetAllMediaType(int pageNumber, int pageSize);
    Task<MediaTypeApiModel?> GetMediaTypeById(int id);

    Task<MediaTypeApiModel> AddMediaType(MediaTypeApiModel newMediaTypeApiModel);

    Task<bool> UpdateMediaType(MediaTypeApiModel mediaTypeApiModel);

    Task<bool> DeleteMediaType(int id);
    Task<PagedList<PlaylistApiModel>> GetAllPlaylist(int pageNumber, int pageSize);
    Task<PlaylistApiModel> GetPlaylistById(int id);

    Task<PlaylistApiModel> AddPlaylist(PlaylistApiModel newPlaylistApiModel);

    Task<bool> UpdatePlaylist(PlaylistApiModel playlistApiModel);

    Task<bool> DeletePlaylist(int id);

    Task<PagedList<TrackApiModel>> GetAllTrack(int pageNumber, int pageSize);
    Task<TrackApiModel?> GetTrackById(int id);
    Task<PagedList<TrackApiModel>?> GetTrackByAlbumId(int id, int pageNumber, int pageSize);
    Task<PagedList<TrackApiModel>> GetTrackByGenreId(int id, int pageNumber, int pageSize);

    Task<PagedList<TrackApiModel>> GetTrackByMediaTypeId(int id, int pageNumber, int pageSize);

    Task<PagedList<TrackApiModel>> GetTrackByPlaylistId(int id, int pageNumber, int pageSize);

    Task<TrackApiModel> AddTrack(TrackApiModel newTrackApiModel);

    Task<bool> UpdateTrack(TrackApiModel trackApiModel);
    Task<bool> DeleteTrack(int id);

    Task<PagedList<TrackApiModel>> GetTrackByArtistId(int id, int pageNumber, int pageSize);
    Task<PagedList<TrackApiModel>> GetTrackByInvoiceId(int id, int pageNumber, int pageSize);
}