using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_queue_QueueEnqueue_QueueEnqueue_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_queue_QueueEnqueue_QueueEnqueue_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\queue\\QueueEnqueue\\QueueEnqueue.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
