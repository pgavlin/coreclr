using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _GCHandleCollector_NegTests_NegTests_
    {
        [Fact]
        public void _GCHandleCollector_NegTests_NegTests_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\GCHandleCollector\\NegTests\\NegTests.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
