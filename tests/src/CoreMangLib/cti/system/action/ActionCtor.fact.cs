using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_action_ActionCtor_ActionCtor_
    {
        [OuterLoop]
        [Fact]
        public void _system_action_ActionCtor_ActionCtor_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\action\\ActionCtor\\ActionCtor.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
