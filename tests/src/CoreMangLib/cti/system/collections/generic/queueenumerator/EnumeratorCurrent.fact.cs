using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_queueenumerator_EnumeratorCurrent_EnumeratorCurrent_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_queueenumerator_EnumeratorCurrent_EnumeratorCurrent_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\queueenumerator\\EnumeratorCurrent\\EnumeratorCurrent.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
