using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Devirtualization_sealedclass_sealedclass_
    {
        [OuterLoop]
        [Fact]
        public void _Devirtualization_sealedclass_sealedclass_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Devirtualization\\sealedclass\\sealedclass.cmd");
        }
    }
}
