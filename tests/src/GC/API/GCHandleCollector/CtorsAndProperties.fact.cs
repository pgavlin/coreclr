using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _GCHandleCollector_CtorsAndProperties_CtorsAndProperties_
    {
        [OuterLoop]
        [Fact]
        public void _GCHandleCollector_CtorsAndProperties_CtorsAndProperties_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\GCHandleCollector\\CtorsAndProperties\\CtorsAndProperties.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
