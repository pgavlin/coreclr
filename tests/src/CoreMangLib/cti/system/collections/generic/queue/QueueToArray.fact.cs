using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_queue_QueueToArray_QueueToArray_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_queue_QueueToArray_QueueToArray_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\queue\\QueueToArray\\QueueToArray.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
