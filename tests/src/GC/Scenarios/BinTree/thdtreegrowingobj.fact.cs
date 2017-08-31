using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    class _BinTree_thdtreegrowingobj_thdtreegrowingobj_
    {
        [Fact]
        public void _BinTree_thdtreegrowingobj_thdtreegrowingobj_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Scenarios\\BinTree\\thdtreegrowingobj\\thdtreegrowingobj.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
