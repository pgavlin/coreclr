using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _GC_CollectionCountTest_CollectionCountTest_
    {
        [Fact]
        public void _GC_CollectionCountTest_CollectionCountTest_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\GC\\CollectionCountTest\\CollectionCountTest.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
