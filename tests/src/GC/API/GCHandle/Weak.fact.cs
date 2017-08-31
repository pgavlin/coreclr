using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _GCHandle_Weak_Weak_
    {
        [OuterLoop]
        [Fact]
        public void _GCHandle_Weak_Weak_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\GCHandle\\Weak\\Weak.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
