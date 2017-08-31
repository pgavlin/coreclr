using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_queue_QueueDequeue_QueueDequeue_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_queue_QueueDequeue_QueueDequeue_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\queue\\QueueDequeue\\QueueDequeue.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
