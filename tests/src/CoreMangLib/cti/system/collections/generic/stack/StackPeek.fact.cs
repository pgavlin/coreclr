using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_stack_StackPeek_StackPeek_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_stack_StackPeek_StackPeek_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\stack\\StackPeek\\StackPeek.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
