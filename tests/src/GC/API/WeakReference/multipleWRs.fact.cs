using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    public class _WeakReference_multipleWRs_multipleWRs_
    {
        [Fact]
        public void _WeakReference_multipleWRs_multipleWRs_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\API\\WeakReference\\multipleWRs\\multipleWRs.cmd");
        }
    }
}
