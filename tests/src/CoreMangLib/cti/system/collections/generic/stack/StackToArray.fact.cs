using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_stack_StackToArray_StackToArray_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_stack_StackToArray_StackToArray_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\stack\\StackToArray\\StackToArray.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
