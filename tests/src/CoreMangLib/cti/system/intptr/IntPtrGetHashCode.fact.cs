using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_intptr_IntPtrGetHashCode_IntPtrGetHashCode_
    {
        [OuterLoop]
        [Fact]
        public void _system_intptr_IntPtrGetHashCode_IntPtrGetHashCode_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\intptr\\IntPtrGetHashCode\\IntPtrGetHashCode.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
