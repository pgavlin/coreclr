using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _Invoke_callvirt__speed_reltest1__speed_reltest1_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_callvirt__speed_reltest1__speed_reltest1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\callvirt\\_speed_reltest1\\_speed_reltest1.cmd");
        }
    }
}
