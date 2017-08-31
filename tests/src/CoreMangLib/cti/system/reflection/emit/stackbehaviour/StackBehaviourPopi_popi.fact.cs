using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_emit_stackbehaviour_StackBehaviourPopi_popi_StackBehaviourPopi_popi_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_emit_stackbehaviour_StackBehaviourPopi_popi_StackBehaviourPopi_popi_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\emit\\stackbehaviour\\StackBehaviourPopi_popi\\StackBehaviourPopi_popi.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
