using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_stack_StackCopyTo_StackCopyTo_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_stack_StackCopyTo_StackCopyTo_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\stack\\StackCopyTo\\StackCopyTo.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
