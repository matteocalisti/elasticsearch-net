// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
// Run the following in the root of the repository:
//
// TODO - RUN INSTRUCTIONS
//
// ------------------------------------------------

using System.Threading;
using System.Threading.Tasks;

#nullable restore
namespace Nest
{
	public class SnapshotNamespace : NamespacedClientProxy
	{
		internal SnapshotNamespace(ElasticClient client) : base(client)
		{
		}

		public CleanupRepositoryResponse CleanupRepository(ICleanupRepositoryRequest request)
		{
			return DoRequest<ICleanupRepositoryRequest, CleanupRepositoryResponse>(request, request.RequestParameters);
		}

		public Task<CleanupRepositoryResponse> CleanupRepositoryAsync(ICleanupRepositoryRequest request, CancellationToken cancellationToken = default)
		{
			return DoRequestAsync<ICleanupRepositoryRequest, CleanupRepositoryResponse>(request, request.RequestParameters, cancellationToken);
		}

		public CloneSnapshotResponse CloneSnapshot(ICloneSnapshotRequest request)
		{
			return DoRequest<ICloneSnapshotRequest, CloneSnapshotResponse>(request, request.RequestParameters);
		}

		public Task<CloneSnapshotResponse> CloneSnapshotAsync(ICloneSnapshotRequest request, CancellationToken cancellationToken = default)
		{
			return DoRequestAsync<ICloneSnapshotRequest, CloneSnapshotResponse>(request, request.RequestParameters, cancellationToken);
		}

		public SnapshotResponse Snapshot(ISnapshotRequest request)
		{
			return DoRequest<ISnapshotRequest, SnapshotResponse>(request, request.RequestParameters);
		}

		public Task<SnapshotResponse> SnapshotAsync(ISnapshotRequest request, CancellationToken cancellationToken = default)
		{
			return DoRequestAsync<ISnapshotRequest, SnapshotResponse>(request, request.RequestParameters, cancellationToken);
		}

		public CreateRepositoryResponse CreateRepository(ICreateRepositoryRequest request)
		{
			return DoRequest<ICreateRepositoryRequest, CreateRepositoryResponse>(request, request.RequestParameters);
		}

		public Task<CreateRepositoryResponse> CreateRepositoryAsync(ICreateRepositoryRequest request, CancellationToken cancellationToken = default)
		{
			return DoRequestAsync<ICreateRepositoryRequest, CreateRepositoryResponse>(request, request.RequestParameters, cancellationToken);
		}

		public DeleteSnapshotResponse DeleteSnapshot(IDeleteSnapshotRequest request)
		{
			return DoRequest<IDeleteSnapshotRequest, DeleteSnapshotResponse>(request, request.RequestParameters);
		}

		public Task<DeleteSnapshotResponse> DeleteSnapshotAsync(IDeleteSnapshotRequest request, CancellationToken cancellationToken = default)
		{
			return DoRequestAsync<IDeleteSnapshotRequest, DeleteSnapshotResponse>(request, request.RequestParameters, cancellationToken);
		}

		public DeleteRepositoryResponse DeleteRepository(IDeleteRepositoryRequest request)
		{
			return DoRequest<IDeleteRepositoryRequest, DeleteRepositoryResponse>(request, request.RequestParameters);
		}

		public Task<DeleteRepositoryResponse> DeleteRepositoryAsync(IDeleteRepositoryRequest request, CancellationToken cancellationToken = default)
		{
			return DoRequestAsync<IDeleteRepositoryRequest, DeleteRepositoryResponse>(request, request.RequestParameters, cancellationToken);
		}

		public GetSnapshotResponse GetSnapshot(IGetSnapshotRequest request)
		{
			return DoRequest<IGetSnapshotRequest, GetSnapshotResponse>(request, request.RequestParameters);
		}

		public Task<GetSnapshotResponse> GetSnapshotAsync(IGetSnapshotRequest request, CancellationToken cancellationToken = default)
		{
			return DoRequestAsync<IGetSnapshotRequest, GetSnapshotResponse>(request, request.RequestParameters, cancellationToken);
		}

		public GetRepositoryResponse GetRepository(IGetRepositoryRequest request)
		{
			return DoRequest<IGetRepositoryRequest, GetRepositoryResponse>(request, request.RequestParameters);
		}

		public Task<GetRepositoryResponse> GetRepositoryAsync(IGetRepositoryRequest request, CancellationToken cancellationToken = default)
		{
			return DoRequestAsync<IGetRepositoryRequest, GetRepositoryResponse>(request, request.RequestParameters, cancellationToken);
		}

		public RestoreResponse Restore(IRestoreRequest request)
		{
			return DoRequest<IRestoreRequest, RestoreResponse>(request, request.RequestParameters);
		}

		public Task<RestoreResponse> RestoreAsync(IRestoreRequest request, CancellationToken cancellationToken = default)
		{
			return DoRequestAsync<IRestoreRequest, RestoreResponse>(request, request.RequestParameters, cancellationToken);
		}

		public SnapshotStatusResponse Status(ISnapshotStatusRequest request)
		{
			return DoRequest<ISnapshotStatusRequest, SnapshotStatusResponse>(request, request.RequestParameters);
		}

		public Task<SnapshotStatusResponse> StatusAsync(ISnapshotStatusRequest request, CancellationToken cancellationToken = default)
		{
			return DoRequestAsync<ISnapshotStatusRequest, SnapshotStatusResponse>(request, request.RequestParameters, cancellationToken);
		}

		public VerifyRepositoryResponse VerifyRepository(IVerifyRepositoryRequest request)
		{
			return DoRequest<IVerifyRepositoryRequest, VerifyRepositoryResponse>(request, request.RequestParameters);
		}

		public Task<VerifyRepositoryResponse> VerifyRepositoryAsync(IVerifyRepositoryRequest request, CancellationToken cancellationToken = default)
		{
			return DoRequestAsync<IVerifyRepositoryRequest, VerifyRepositoryResponse>(request, request.RequestParameters, cancellationToken);
		}
	}
}