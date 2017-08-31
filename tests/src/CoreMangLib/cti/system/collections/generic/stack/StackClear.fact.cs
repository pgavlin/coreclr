using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_stack_StackClear_StackClear_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_stack_StackClear_StackClear_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\stack\\StackClear\\StackClear.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
