using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_stackenumerator_StackEnumeratorCurrent_StackEnumeratorCurrent_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_stackenumerator_StackEnumeratorCurrent_StackEnumeratorCurrent_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\stackenumerator\\StackEnumeratorCurrent\\StackEnumeratorCurrent.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
