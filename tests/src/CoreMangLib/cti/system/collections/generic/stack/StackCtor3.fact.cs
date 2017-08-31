using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_stack_StackCtor3_StackCtor3_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_stack_StackCtor3_StackCtor3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\stack\\StackCtor3\\StackCtor3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
