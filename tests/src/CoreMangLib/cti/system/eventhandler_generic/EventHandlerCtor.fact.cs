using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_eventhandler_generic_EventHandlerCtor_EventHandlerCtor_
    {
        [OuterLoop]
        [Fact]
        public void _system_eventhandler_generic_EventHandlerCtor_EventHandlerCtor_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\eventhandler_generic\\EventHandlerCtor\\EventHandlerCtor.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
