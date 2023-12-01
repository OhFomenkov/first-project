n, m = 3, 3
inf = 1000000000
dp = [[inf] * m for i in range(n)]
def min_penalty(matrix, i, j):
    if (dp[i][j] != inf):
        return dp[i][j]

    if i == n - 1:
        dp[i][j] = matrix[i][j]
        return matrix[i][j]

    left_penalty = min_penalty(matrix, i + 1, j - 1) if j > 0 else float('inf')
    down_penalty = min_penalty(matrix, i + 1, j)
    right_penalty = min_penalty(matrix, i + 1, j + 1) if j < len(matrix[0]) - 1 else float('inf')

    dp[i][j] = min(dp[i][j], matrix[i][j] + min(left_penalty, down_penalty, right_penalty))
    return dp[i][j]
# Пример использования
matrix = [[3, 1, 1],
          [5, 5, 1],
          [5, 5, 5]]

ans = inf
for j in range(m):
    ans = min(ans, min_penalty(matrix, 0, 1))
print(ans)