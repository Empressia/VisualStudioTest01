using data = VisualStudioTest01.data;

namespace VisualStudioTest01 {
	internal class SomethingLikeDBWrapper {
		public Task register(data.Sample? sample) {
			// copy this if statement to another method in this class.
			if(sample == null) { throw new Exception(); }
			return Task.Run(() => { });
		}
		public Task register(data.Task? task) {
			return Task.Run(() => { });
		}
		public Task register(string? s) {
			return Task.Run(() => { });
		}
		public Task register(int? i) {
			return Task.Run(() => { });
		}
		public Task register(long? d) {
			return Task.Run(() => { });
		}
		public Task register(DateTimeOffset? datetime) {
			return Task.Run(() => { });
		}

	}
}
