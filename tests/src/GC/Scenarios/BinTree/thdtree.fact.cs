using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    class _BinTree_thdtree_thdtree_
    {
        [Fact]
        public void _BinTree_thdtree_thdtree_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Scenarios\\BinTree\\thdtree\\thdtree.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
