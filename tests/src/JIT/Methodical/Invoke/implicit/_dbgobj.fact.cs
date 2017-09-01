using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _Invoke_implicit__dbgobj__dbgobj_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_implicit__dbgobj__dbgobj_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\implicit\\_dbgobj\\_dbgobj.cmd");
        }
    }
}
