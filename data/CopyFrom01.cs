using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudioTest01.data {
	internal class CopyFrom01 {
		public void testMethod01() {
			// copy this to CopyTo01.testMethod01.
			data.Task t = new Task();
		}
		public void testMethod02() {
			// copy this to CopyTo01.testMethod02.
			data.Task t = new data.Task();
			Sample s = new Sample();
		}
		public void testMethod03() {
			// copy this to CopyTo01.testMethod03.
			data.Task t = new data.Task();
			data.Sample s = new Sample();
		}
		public void testMethod04() {
			// copy this to CopyTo01.testMethod04.
			System.Threading.Tasks.Task.Run(() => {
				Task t = new Task();
			});
		}
	}
}
