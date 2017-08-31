using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_intptr_IntPtrEquals_IntPtrEquals_
    {
        [OuterLoop]
        [Fact]
        public void _system_intptr_IntPtrEquals_IntPtrEquals_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\intptr\\IntPtrEquals\\IntPtrEquals.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
