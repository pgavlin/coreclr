using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _CLR_x86_JIT_V1_M09_5_PDC_b10940_b10940a_b10940a_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_M09_5_PDC_b10940_b10940a_b10940a_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-M09.5-PDC\\b10940\\b10940a\\b10940a.cmd");
        }
    }
}
