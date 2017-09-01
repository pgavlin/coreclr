using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _Arrays_misc__speed_dbgselfref__speed_dbgselfref_
    {
        [OuterLoop]
        [Fact]
        public void _Arrays_misc__speed_dbgselfref__speed_dbgselfref_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\misc\\_speed_dbgselfref\\_speed_dbgselfref.cmd");
        }
    }
}
