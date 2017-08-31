using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_eventhandler_generic_EventHandlerEndInvoke_EventHandlerEndInvoke_
    {
        [OuterLoop]
        [Fact]
        public void _system_eventhandler_generic_EventHandlerEndInvoke_EventHandlerEndInvoke_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\eventhandler_generic\\EventHandlerEndInvoke\\EventHandlerEndInvoke.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
