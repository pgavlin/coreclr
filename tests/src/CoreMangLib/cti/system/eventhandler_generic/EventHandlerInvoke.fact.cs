using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_eventhandler_generic_EventHandlerInvoke_EventHandlerInvoke_
    {
        [OuterLoop]
        [Fact]
        public void _system_eventhandler_generic_EventHandlerInvoke_EventHandlerInvoke_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\eventhandler_generic\\EventHandlerInvoke\\EventHandlerInvoke.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
