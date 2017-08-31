using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_queueenumerator_EnumeratorMoveNext_EnumeratorMoveNext_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_queueenumerator_EnumeratorMoveNext_EnumeratorMoveNext_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\queueenumerator\\EnumeratorMoveNext\\EnumeratorMoveNext.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
