using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_eventhandler_generic_EventHandlerBeginInvoke_EventHandlerBeginInvoke_
    {
        [OuterLoop]
        [Fact]
        public void _system_eventhandler_generic_EventHandlerBeginInvoke_EventHandlerBeginInvoke_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\eventhandler_generic\\EventHandlerBeginInvoke\\EventHandlerBeginInvoke.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
