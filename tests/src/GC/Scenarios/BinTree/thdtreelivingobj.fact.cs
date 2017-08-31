using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    class _BinTree_thdtreelivingobj_thdtreelivingobj_
    {
        [Fact]
        public void _BinTree_thdtreelivingobj_thdtreelivingobj_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Scenarios\\BinTree\\thdtreelivingobj\\thdtreelivingobj.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
