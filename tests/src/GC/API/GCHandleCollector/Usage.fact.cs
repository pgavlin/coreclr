using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _GCHandleCollector_Usage_Usage_
    {
        [Fact]
        public void _GCHandleCollector_Usage_Usage_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\GCHandleCollector\\Usage\\Usage.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
