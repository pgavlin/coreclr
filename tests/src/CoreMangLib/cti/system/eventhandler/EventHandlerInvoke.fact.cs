using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_eventhandler_EventHandlerInvoke_EventHandlerInvoke_
    {
        [OuterLoop]
        [Fact]
        public void _system_eventhandler_EventHandlerInvoke_EventHandlerInvoke_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\eventhandler\\EventHandlerInvoke\\EventHandlerInvoke.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
