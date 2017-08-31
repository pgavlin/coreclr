using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_stackenumerator_StackEnumeratorMoveNext_StackEnumeratorMoveNext_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_stackenumerator_StackEnumeratorMoveNext_StackEnumeratorMoveNext_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\stackenumerator\\StackEnumeratorMoveNext\\StackEnumeratorMoveNext.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
