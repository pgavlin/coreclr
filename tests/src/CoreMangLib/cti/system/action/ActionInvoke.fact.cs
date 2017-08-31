using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_action_ActionInvoke_ActionInvoke_
    {
        [OuterLoop]
        [Fact]
        public void _system_action_ActionInvoke_ActionInvoke_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\action\\ActionInvoke\\ActionInvoke.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
