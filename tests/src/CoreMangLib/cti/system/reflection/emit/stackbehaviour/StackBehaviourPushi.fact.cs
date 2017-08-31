using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_emit_stackbehaviour_StackBehaviourPushi_StackBehaviourPushi_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_emit_stackbehaviour_StackBehaviourPushi_StackBehaviourPushi_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\emit\\stackbehaviour\\StackBehaviourPushi\\StackBehaviourPushi.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
