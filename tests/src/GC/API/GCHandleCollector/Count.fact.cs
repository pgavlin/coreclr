using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _GCHandleCollector_Count_Count_
    {
        [Fact]
        public void _GCHandleCollector_Count_Count_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\GCHandleCollector\\Count\\Count.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
