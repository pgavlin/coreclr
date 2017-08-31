using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_stackenumerator_StackEnumeratorDispose_StackEnumeratorDispose_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_stackenumerator_StackEnumeratorDispose_StackEnumeratorDispose_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\stackenumerator\\StackEnumeratorDispose\\StackEnumeratorDispose.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
